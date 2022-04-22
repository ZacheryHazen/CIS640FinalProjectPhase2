/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Connects the Rooms with the Tags associated with them
    /// </summary>
    public class RoomTag
    {
        /// <summary>The id of the room</summary>
        public int RoomId { get; set; } 

        /// <summary>The room object</summary>
        public Room Room {get; set; }

        /// <summary>The id of the tag</summary>
        public int TagId { get; set; }

        /// <summary>The room object</summary>
        public Tag Tag {get; set; }
    }
}