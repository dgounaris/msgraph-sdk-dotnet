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
    /// The type Managed App Policy Deployment Summary.
    /// </summary>
    
    public partial class ManagedAppPolicyDeploymentSummary : Entity
    {
    
		///<summary>
		/// The ManagedAppPolicyDeploymentSummary constructor
		///</summary>
        public ManagedAppPolicyDeploymentSummary()
        {
            this.ODataType = "microsoft.graph.managedAppPolicyDeploymentSummary";
        }
	
        /// <summary>
        /// Gets or sets configuration deployed user count.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("configurationDeployedUserCount")]
        public Int32? ConfigurationDeployedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets configuration deployment summary per app.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("configurationDeploymentSummaryPerApp")]
        public IEnumerable<ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last refresh time.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("lastRefreshTime")]
        public DateTimeOffset? LastRefreshTime { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the entity.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

