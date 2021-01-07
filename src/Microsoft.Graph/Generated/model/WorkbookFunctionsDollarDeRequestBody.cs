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
    /// The type WorkbookFunctionsDollarDeRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsDollarDeRequestBody
    {
    
        /// <summary>
        /// Gets or sets FractionalDollar.
        /// </summary>
        [JsonPropertyName("fractionalDollar")]
        public System.Text.Json.JsonDocument FractionalDollar { get; set; }
    
        /// <summary>
        /// Gets or sets Fraction.
        /// </summary>
        [JsonPropertyName("fraction")]
        public System.Text.Json.JsonDocument Fraction { get; set; }
    
    }
}
