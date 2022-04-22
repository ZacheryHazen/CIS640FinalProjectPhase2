/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents a room on the map
    /// </summary>
    public class Room : Node
    {
        /// <summary>The room number associated with the room</summary>
        public string RoomNumber { get; set; }
        // Has to be a string, since some room numbers have letters in them, i.e. DUE1086A

        /// <summary>The id of the floor the room is on</summary>
        public int FloorId { get; set; }

        /// <summary>The Floor object</summary>
        public Floor Floor {get; set; }

        /// <summary>The list of RoomTag objects</summary>
        public IList<RoomTag> RoomTags {get; set; }
    }
}