// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Planner Bucket Task Board Task Format.
    /// </summary>
    
    public partial class PlannerBucketTaskBoardTaskFormat : Entity
    {
    
		///<summary>
		/// The PlannerBucketTaskBoardTaskFormat constructor
		///</summary>
        public PlannerBucketTaskBoardTaskFormat()
        {
            this.ODataType = "microsoft.graph.plannerBucketTaskBoardTaskFormat";
        }
	
        /// <summary>
        /// Gets or sets order hint.
        /// Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
        /// </summary>
        [JsonPropertyName("orderHint")]
        public string OrderHint { get; set; }
    
    }
}

