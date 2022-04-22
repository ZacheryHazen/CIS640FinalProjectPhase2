/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents a location on a map 
    /// </summary>
    public class Node
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The horizontal coordinate</summary>
        public ulong X { get; set; }

        /// <summary>The vertical coordinate</summary>
        public ulong Y { get; set; }

        /// <summary>The date this node was created on</summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>The date this node was updated on</summary>
        public DateTime UpdatedOn { get; set; }

        ///<summary>The id of the building the Node lives in</summary>
        public int BuildingId { get; set; }

        ///<summary>The building the Node lives in</summary>
        public Building Building { get; set; }

        /// <summary>The collection of Edge objects from the Node</summary>
        public ICollection<Edge> FromEdges {get; set; }

        /// <summary>The collection of Edge objects to the Node</summary>
        public ICollection<Edge> ToEdges {get; set; }

        /// <summary>Whether the node is accessible or not</summary>
        public bool Accessible { get; set; }
    }
}