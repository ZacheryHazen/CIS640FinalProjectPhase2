/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents a floor on the map
    /// </summary>
    public class Floor
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>
        /// The level of the building the floor is on expressed as a
        /// human-readable string.
        /// </summary>
        public string FloorString { get; set; }

        /// <summary>
        /// Machine-readable floor level. "First floor" should equal 1. Any 
        /// basements should go decrease from 1 in integer increments and any 
        /// additional floors should increase from 1 in the same manner. This 
        /// integer can be negative.
        /// </summary>
        public int FloorNumber { get; set; }

        /// <summary>The id of the building the floor is in</summary>
        public int BuildingId { get; set; }

        /// <summary>The building object</summary>
        public Building Building {get; set; }

        /// <summary>The location of the map of this floor</summary>
        public string FloorMap { get; set; }

        /// <summary>The date this floor was created on</summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>The date this floor was updated on</summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>The collection of Room objects</summary>
        public ICollection<Room> Rooms { get; set; }
    }
}