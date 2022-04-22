/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents a door on the map
    /// </summary>
    public class Door : Node
    {
        /// <summary>The collection of DoorHours objects</summary>
        public ICollection<DoorHours> DoorHours {get; set; }

    }
}