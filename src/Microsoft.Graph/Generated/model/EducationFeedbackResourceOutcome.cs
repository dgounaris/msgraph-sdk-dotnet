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
    /// The type Education Feedback Resource Outcome.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationFeedbackResourceOutcome>))]
    public partial class EducationFeedbackResourceOutcome : EducationOutcome
    {
    
        ///<summary>
        /// The EducationFeedbackResourceOutcome constructor
        ///</summary>
        public EducationFeedbackResourceOutcome()
        {
            this.ODataType = "microsoft.graph.educationFeedbackResourceOutcome";
        }

        /// <summary>
        /// Gets or sets feedback resource.
        /// The actual feedback resource.
        /// </summary>
        [JsonPropertyName("feedbackResource")]
        public EducationResource FeedbackResource { get; set; }
    
        /// <summary>
        /// Gets or sets resource status.
        /// The status of the feedback resource. The possible values are: notPublished, pendingPublish, published, failedPublish, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("resourceStatus")]
        public EducationFeedbackResourceOutcomeStatus? ResourceStatus { get; set; }
    
    }
}
