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
    /// The type WorkbookFunctionsLogRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsLogRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonPropertyName("number")]
        public System.Text.Json.JsonDocument Number { get; set; }
    
        /// <summary>
        /// Gets or sets Base.
        /// </summary>
        [JsonPropertyName("base")]
        public System.Text.Json.JsonDocument Base { get; set; }
    
    }
}
