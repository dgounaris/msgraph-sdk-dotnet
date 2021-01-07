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
    /// The type WorkbookFunctionsDvarPRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsDvarPRequestBody
    {
    
        /// <summary>
        /// Gets or sets Database.
        /// </summary>
        [JsonPropertyName("database")]
        public System.Text.Json.JsonDocument Database { get; set; }
    
        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonPropertyName("field")]
        public System.Text.Json.JsonDocument Field { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonPropertyName("criteria")]
        public System.Text.Json.JsonDocument Criteria { get; set; }
    
    }
}
