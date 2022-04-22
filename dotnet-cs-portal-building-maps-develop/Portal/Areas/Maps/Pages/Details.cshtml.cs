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
    /// The model (and controller) for the building page.
    /// </summary>
    public class DetailsModel : PageModel
    {
        /// <summary>
        /// The building this page details
        /// </summary>
        public Building Building { get; private set; }

        /// <summary>
        /// The floors this building contains
        /// </summary>
        private List<Floor> BuildingFloors { get; set; }

        /// <summary>
        /// The current floor the page is displaying
        /// </summary>
        public int CurrentFloor { get; private set; } = 1;

        /// <summary>
        /// The potential tags applying to rooms in this building
        /// </summary>
        public List<Tag> TagList { get; private set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly PortalContext _context;

        public DetailsModel(PortalContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Handles the GET request for the index page.
        /// </summary>
        /// <returns>
        /// A Task which grabs this page's building and places it in a variable
        /// </returns>
        public async Task OnGetAsync(string slug)
        {
            Building = await _context.Buildings
                        .FirstAsync<Building>(b => b.Slug == slug);
            
            // Kind of a hack to make the list of items in Building work
            BuildingFloors = await _context.Floors
                .Where(f => f.BuildingId == Building.Id).ToListAsync<Floor>();

            TagList = await _context.Tags.ToListAsync<Tag>();
        }
    }
}
