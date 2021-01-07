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
    /// The type Todo.
    /// </summary>
    
    public partial class Todo : Entity
    {
    
		///<summary>
		/// The Todo constructor
		///</summary>
        public Todo()
        {
            this.ODataType = "microsoft.graph.todo";
        }
	
        /// <summary>
        /// Gets or sets lists.
        /// The task lists in the users mailbox.
        /// </summary>
        [JsonPropertyName("lists")]
        public ITodoListsCollectionPage Lists { get; set; }
    
    }
}

