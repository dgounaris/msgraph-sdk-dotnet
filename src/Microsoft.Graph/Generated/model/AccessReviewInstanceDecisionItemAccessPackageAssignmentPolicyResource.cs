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
    /// The type AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource.
    /// </summary>
    public partial class AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource : AccessReviewInstanceDecisionItemResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource"/> class.
        /// </summary>
        public AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource()
        {
            this.ODataType = "microsoft.graph.accessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource";
        }

        /// <summary>
        /// Gets or sets accessPackageDisplayName.
        /// </summary>
        [JsonPropertyName("accessPackageDisplayName")]
        public string AccessPackageDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets accessPackageId.
        /// </summary>
        [JsonPropertyName("accessPackageId")]
        public string AccessPackageId { get; set; }
    
    }
}
