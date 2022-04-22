/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents a building on the map
    /// </summary>
    public class Building
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The name of the building</summary>
        public string BuildingName { get; set; }

        /// <summary>The abbreviation of the building name</summary>
        public string BuildingAbrev { get; set; }

        /// <summary>
        /// The human-readible slug for the building. Should typically be the 
        /// building's name with "Hall" removed and with dashes replacing spaces.
        /// For example, Anderson Hall should be "Anderson".
        /// </summary>
        public string Slug { get; set; }

        /// <summary>The horizontal coordinate</summary>
        public ulong X { get; set; }

        /// <summary>The vertical coordinate</summary>
        public ulong Y { get; set; }

        /// <summary>The date this building was created on</summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>The date this building was updated on</summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>The collection of Node objects</summary>
        public ICollection<Node> Nodes { get; set; }

        /// <summary>The collection of Edge objects</summary>
        public ICollection<Edge> Edges { get; set; }

        /// <summary>The collection of Floor objects</summary>
        public ICollection<Floor> Floors { get; set; }

        /// <summary>
        /// The directory that this building's images (should) be stored in.
        /// </summary>
        public string FloorImageDirectory => $"/BuildingSVGs/{Slug}";

        /// <summary>
        /// Returns the url to the floor map image for a floor number, if it 
        /// exists.
        /// </summary>
        /// <param name="floorNumber">
        /// The number of the floor to fetch an image for
        /// </param>
        /// <returns>A string representing the path to the floor's map</returns>
        public string GetFloorImageUrl(int floorNumber) {
            Floor currentFloor = this.Floors
                .First<Floor>(f => f.FloorNumber == floorNumber);
            return $"{FloorImageDirectory}/{currentFloor.FloorMap}";
        }
    }
}