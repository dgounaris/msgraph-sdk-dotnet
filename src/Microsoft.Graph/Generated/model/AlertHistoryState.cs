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
    /// The type AlertHistoryState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AlertHistoryState>))]
    public partial class AlertHistoryState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertHistoryState"/> class.
        /// </summary>
        public AlertHistoryState()
        {
            this.ODataType = "microsoft.graph.alertHistoryState";
        }

        /// <summary>
        /// Gets or sets appId.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets assignedTo.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [JsonPropertyName("comments")]
        public IEnumerable<string> Comments { get; set; }
    
        /// <summary>
        /// Gets or sets feedback.
        /// </summary>
        [JsonPropertyName("feedback")]
        public AlertFeedback? Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public AlertStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets updatedDateTime.
        /// </summary>
        [JsonPropertyName("updatedDateTime")]
        public DateTimeOffset? UpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }
    
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
