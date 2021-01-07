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
    /// The type Endpoint.
    /// </summary>
    
    public partial class Endpoint : DirectoryObject
    {
    
		///<summary>
		/// The Endpoint constructor
		///</summary>
        public Endpoint()
        {
            this.ODataType = "microsoft.graph.endpoint";
        }
	
        /// <summary>
        /// Gets or sets capability.
        /// Describes the capability that is associated with this resource. (e.g. Messages, Conversations, etc.)  Not nullable. Read-only.
        /// </summary>
        [JsonPropertyName("capability")]
        public string Capability { get; set; }
    
        /// <summary>
        /// Gets or sets provider id.
        /// Application id of the publishing underlying service. Not nullable. Read-only.
        /// </summary>
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
    
        /// <summary>
        /// Gets or sets provider name.
        /// Name of the publishing underlying service. Read-only.
        /// </summary>
        [JsonPropertyName("providerName")]
        public string ProviderName { get; set; }
    
        /// <summary>
        /// Gets or sets provider resource id.
        /// For Microsoft 365 groups, this is set to a well-known name for the resource (e.g. Yammer.FeedURL etc.). Not nullable. Read-only.
        /// </summary>
        [JsonPropertyName("providerResourceId")]
        public string ProviderResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets uri.
        /// URL of the published resource. Not nullable. Read-only.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    
    }
}

