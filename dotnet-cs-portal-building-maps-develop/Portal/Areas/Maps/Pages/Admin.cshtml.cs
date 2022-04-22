/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ksu.Cs.Portal.Areas.Maps.Models;
using Ksu.Cs.Portal.Data;
using Microsoft.AspNetCore.Http;
using Ksu.Cs.Portal.Controllers;
using Ksu.Cs.Portal.Areas.Maps.Services;
using System.IO;

namespace Ksu.Cs.Portal.Areas.Maps.Pages
{
    public class Admin : PageModel
    {
        private readonly ILogger<Admin> _logger;

        private readonly PortalContext _context;

        private readonly IProcessRequestQueue _queue;

        public Admin(PortalContext context, ILogger<Admin> logger, IProcessRequestQueue queue)
        {
            _logger = logger;
            _context = context;
            _queue = queue;
        }

        public void OnGet()
        {

        }
        
        /// <summary>
        /// Handles the POST request for the admin page.
        /// </summary>
        /// <param name="myfile">The file content of the pdf being uploaded</param>
        /// <returns>
        /// A Task which creates a temporary file path, creates a file stream, and enqueues the file 
        /// into the asynchronous Process Request Queue
        /// </returns>
        // [Authorize(Policy = "AdminOnly")]
        public async Task OnPostAsync(IFormFile myfile) 
        {
            var filePath = Path.GetTempFileName();
            using var stream = System.IO.File.Create(filePath);
            await myfile.CopyToAsync(stream);

            await _queue.EnqueueAsync(new ProcessRequest() 
            {
                FilePath = filePath
            });
        }
    }
}
