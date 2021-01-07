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
    /// The type Teams App Installation.
    /// </summary>
    
    public partial class TeamsAppInstallation : Entity
    {
    
		///<summary>
		/// The TeamsAppInstallation constructor
		///</summary>
        public TeamsAppInstallation()
        {
            this.ODataType = "microsoft.graph.teamsAppInstallation";
        }
	
        /// <summary>
        /// Gets or sets teams app.
        /// The app that is installed.
        /// </summary>
        [JsonPropertyName("teamsApp")]
        public TeamsApp TeamsApp { get; set; }
    
        /// <summary>
        /// Gets or sets teams app definition.
        /// The details of this version of the app.
        /// </summary>
        [JsonPropertyName("teamsAppDefinition")]
        public TeamsAppDefinition TeamsAppDefinition { get; set; }
    
    }
}

