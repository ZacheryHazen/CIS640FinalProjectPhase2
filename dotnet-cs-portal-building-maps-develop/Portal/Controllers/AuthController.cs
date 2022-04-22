using System;
using System.IO;
using System.Net.Http;
using System.Linq;
using System.Xml.Linq;
using System.Security.Claims;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ksu.Cs.Portal.Data;
using Ksu.Cs.Portal.Models;

namespace Ksu.Cs.Portal.Controllers
{
    /// <summary>
    /// A controller to handle authentication using K-State's Central Authentication Service
    /// </summary>
    [AllowAnonymous]
    [Route("Auth")]
    public class AuthController : Controller
    {
        readonly string _serviceHost;// = "https://localhost:44349/Auth/"; //"https://portal.cs.ksu.edu/auth/";
        readonly string _casHost;// = "https://signin.k-state.edu/WebISO/";
        private readonly PortalContext _context;
        private readonly IHttpClientFactory _httpClientFactory;

        #region Route Methods

        /// <summary>
        /// Constructs a new AuthController with dynamic injection
        /// </summary>
        /// <param name="context">The database context</param>
        /// <param name="configuration">The application configuration</param>
        /// <param name="httpClientFactory">A factory for creating HTTP clients</param>
        public AuthController(PortalContext context, IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
            _serviceHost = configuration["CAS:ServiceHost"];
            _casHost = configuration["CAS:CASHost"];
        }

        /// <summary>
        /// Starts the login process
        /// </summary>
        /// <param name="returnUrl">The attempted URL which needs saved to return the user after authentication</param>
        /// <returns>A redirect to the K-State CAS server login URL</returns>
        [Route("Login")]
        public IActionResult Login(string returnUrl = null)
        {
            if (returnUrl != null) TempData["ReturnUrl"] = returnUrl;
            string url = $"{_casHost}/login?service={Uri.EscapeDataString(_serviceHost + "Ticket")}";
            return Redirect(url);
        }

        /// <summary>
        /// Logs the user out of the application
        /// </summary>
        /// <returns>A redirect to the K-State CAS server logout URL</returns>
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect($"{_casHost}/logout");
        }

        #endregion 

        #region Helper Methods

        /// <summary>
        /// Processes the ticket generated as part of the CAS login process
        /// </summary>
        /// <param name="ticket">The ticket to validate</param>
        /// <returns>On a success, redirects to the saved requested route or home page; on an error returns a status code</returns>
        [Route("Ticket")]
        public async Task<IActionResult> Ticket(string ticket)
        {
            var url = $"{_casHost}serviceValidate?ticket={ticket}&service={Uri.EscapeDataString(_serviceHost)}Ticket";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using Stream stream = await response.Content.ReadAsStreamAsync();
                using StreamReader reader = new(stream);
                string body = await reader.ReadToEndAsync();

                XDocument doc = XDocument.Parse(body);
                var element = doc.Descendants("{http://www.yale.edu/tp/cas}user").FirstOrDefault();
                if (element != null)
                {
                    string eid = element.Value;

                    PortalUser user = await FindOrCreatePortalUser(eid);

                    var userClaims = new List<Claim>()
                    {
                        new Claim("ID", user .Id .ToString()),
                        new Claim("EID", user.Eid),
                        new Claim(ClaimTypes.Name, user.FullName),
                        new Claim(ClaimTypes.Email, user.Email)
                    };
                    if (user.IsStudent) userClaims.Add(new Claim(ClaimTypes.Role, "Student"));
                    if (user.IsTeachingAssistant) userClaims.Add(new Claim(ClaimTypes.Role, "Teaching Assistant"));
                    //if(user.IsStaff) userClaims.Add(new Claim(ClaimTypes.Role, "Staff"));
                    if (user.IsFaculty) userClaims.Add(new Claim(ClaimTypes.Role, "Faculty"));
                    if (user.IsAdmin) userClaims.Add(new Claim(ClaimTypes.Role, "Admin"));

                    var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrinciple = new ClaimsPrincipal(new[] { userIdentity });
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrinciple);

                    if (TempData["ReturnUrl"] != null) return Redirect(TempData["ReturnUrl"].ToString());
                    else return Redirect("/");
                }
            }

            return StatusCode(403);
        }

        /// <summary>
        /// A helper method to find the existing user record with <paramref name="eid"/>,
        /// or create a new user if it does not yet exist
        /// </summary>
        /// <param name="eid">The EID of the user</param>
        /// <returns>A user object</returns>
        private async Task<PortalUser> FindOrCreatePortalUser(string eid)
        {
            var user = await _context.PortalUsers.FirstOrDefaultAsync(u => u.Eid == eid);
            if (user != null) return user;

            var url = $"https://www.k-state.edu/People/filter/eid=${eid}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using Stream stream = await response.Content.ReadAsStreamAsync();
                using StreamReader reader = new(stream);

                string body = await reader.ReadToEndAsync();
                XDocument doc = XDocument.Parse(body);
                string firstName = doc.Descendants("fn").Select(x => x.Value).FirstOrDefault();
                string lastName = doc.Descendants("ln").Select(x => x.Value).FirstOrDefault();

                user = new PortalUser()
                {
                    Eid = eid,
                    LastName = lastName,
                    FirstName = firstName,
                    Roles = UserRoles.Student
                };
                _context.PortalUsers.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }

            return null;
        }

        #endregion
    }
}