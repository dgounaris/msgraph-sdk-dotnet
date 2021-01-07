// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ExternalLink.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ExternalLink>))]
    public partial class ExternalLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLink"/> class.
        /// </summary>
        public ExternalLink()
        {
            this.ODataType = "microsoft.graph.externalLink";
        }

        /// <summary>
        /// Gets or sets href.
        /// The url of the link.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
