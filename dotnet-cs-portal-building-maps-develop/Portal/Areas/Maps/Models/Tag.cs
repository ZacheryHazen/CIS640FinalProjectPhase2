/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// The tags that can be added onto a Room
    /// </summary>
    public class Tag
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The name of the tag</summary>
        public string TagName { get; set; }

        /// <summary>The list of RoomTag objects</summary>
        public IList<RoomTag> RoomTags {get; set; }
    }
}