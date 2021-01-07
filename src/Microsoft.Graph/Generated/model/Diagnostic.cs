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
    /// The type Diagnostic.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Diagnostic>))]
    public partial class Diagnostic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Diagnostic"/> class.
        /// </summary>
        public Diagnostic()
        {
            this.ODataType = "microsoft.graph.diagnostic";
        }

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
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
