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
    /// The type Resource Specific Permission Grant.
    /// </summary>
    
    public partial class ResourceSpecificPermissionGrant : DirectoryObject
    {
    
		///<summary>
		/// The ResourceSpecificPermissionGrant constructor
		///</summary>
        public ResourceSpecificPermissionGrant()
        {
            this.ODataType = "microsoft.graph.resourceSpecificPermissionGrant";
        }
	
        /// <summary>
        /// Gets or sets client app id.
        /// </summary>
        [JsonPropertyName("clientAppId")]
        public string ClientAppId { get; set; }
    
        /// <summary>
        /// Gets or sets client id.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets permission.
        /// </summary>
        [JsonPropertyName("permission")]
        public string Permission { get; set; }
    
        /// <summary>
        /// Gets or sets permission type.
        /// </summary>
        [JsonPropertyName("permissionType")]
        public string PermissionType { get; set; }
    
        /// <summary>
        /// Gets or sets resource app id.
        /// </summary>
        [JsonPropertyName("resourceAppId")]
        public string ResourceAppId { get; set; }
    
    }
}

