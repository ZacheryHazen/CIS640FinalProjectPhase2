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

namespace Ksu.Cs.Portal.Areas.Maps.Pages
{
    /// <summary>
    /// The model (and controller) for the maps index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// A list of Buildings to display on the page.
        /// </summary>
        public List<Building> BuildingList { get; private set; }
        public List<Floor> FloorList { get; private set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly PortalContext _context;

        public IndexModel(PortalContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Handles the GET request for the index page.
        /// </summary>
        /// <returns>
        /// A Task which grabs all of the buildings and puts them in the 
        /// BuildingList.
        /// </returns>
        public async Task OnGetAsync()
        {
            BuildingList = await _context.Buildings.ToListAsync<Building>();
            FloorList = await _context.Floors.ToListAsync<Floor>();
        }

        /// <summary>
        /// Handles the POST request for the index page.
        /// </summary>
        /// <param name="search">The string contents of the search bar</param>
        /// <returns>
        /// A Task which grabs all of the buildings if they are not already in
        /// the BuildingList, and sends them to the correct building if they
        /// searched for an identifiable one.
        /// </returns>
        public async Task OnPostAsync(string search)
        { 
            // Make sure the BuildingList has content
            if (BuildingList is null) {
                BuildingList = await _context.Buildings.ToListAsync<Building>();
            }

            if (FloorList is null) {
                FloorList = await _context.Floors.ToListAsync<Floor>();
            }
            
            List<string> searchWords = search.ToLower().Split(" ").ToList<string>();
            searchWords.RemoveAll(w => w.Contains("hall") && w.Contains("room"));
        }
    }
}
