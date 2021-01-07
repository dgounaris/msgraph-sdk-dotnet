// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsConfidence_NormRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsConfidence_NormRequestBody
    {
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [JsonPropertyName("alpha")]
        public System.Text.Json.JsonDocument Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets StandardDev.
        /// </summary>
        [JsonPropertyName("standardDev")]
        public System.Text.Json.JsonDocument StandardDev { get; set; }
    
        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonPropertyName("size")]
        public System.Text.Json.JsonDocument Size { get; set; }
    
    }
}
