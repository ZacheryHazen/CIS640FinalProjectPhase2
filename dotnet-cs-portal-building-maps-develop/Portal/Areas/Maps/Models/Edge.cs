/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Areas.Maps.Models
{
    /// <summary>
    /// Represents the path between two nodes
    /// </summary>
    public class Edge
    {
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The node to start on</summary>
        public int StartNodeId { get; set; }

        /// <summary>The starting Node object</summary>
        public Node StartNode {get; set; }

        /// <summary>The node to end on</summary>
        public int DestinationNodeId { get; set; }

        /// <summary>The destination Node object</summary>
        public Node DestinationNode {get; set; }

        ///<summary>The id of the building the Edge lives in</summary>
        public int BuildingId { get; set; }

        ///<summary>The building the Edge lives in</summary>
        public Building Building { get; set; }

    }
}
