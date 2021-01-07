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
    /// The type WorkbookFunctionsHlookupRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsHlookupRequestBody
    {
    
        /// <summary>
        /// Gets or sets LookupValue.
        /// </summary>
        [JsonPropertyName("lookupValue")]
        public System.Text.Json.JsonDocument LookupValue { get; set; }
    
        /// <summary>
        /// Gets or sets TableArray.
        /// </summary>
        [JsonPropertyName("tableArray")]
        public System.Text.Json.JsonDocument TableArray { get; set; }
    
        /// <summary>
        /// Gets or sets RowIndexNum.
        /// </summary>
        [JsonPropertyName("rowIndexNum")]
        public System.Text.Json.JsonDocument RowIndexNum { get; set; }
    
        /// <summary>
        /// Gets or sets RangeLookup.
        /// </summary>
        [JsonPropertyName("rangeLookup")]
        public System.Text.Json.JsonDocument RangeLookup { get; set; }
    
    }
}
