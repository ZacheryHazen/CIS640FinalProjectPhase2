/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents the hours a door is available to the students
    /// </summary>
    public class DoorHours
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The id of the door</summary>
        public int DoorId { get; set; }

        /// <summary>The Door object</summary>
        public Door Door {get; set; }

        /// <summary>An integer representing the day of the week; Sunday := 0</summary>
        public byte DayOfWeek { get; set; }

        /// <summary>The time the door opens on the given day</summary>
        public TimeSpan OpenTime { get; set; }

        /// <summary>The time the door closes on the given day</summary>
        public TimeSpan CloseTime { get; set; }

    }
}