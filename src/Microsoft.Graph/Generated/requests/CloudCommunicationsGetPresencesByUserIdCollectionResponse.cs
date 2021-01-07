// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodCollectionResponse.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CloudCommunicationsGetPresencesByUserIdCollectionResponse.
    /// </summary>
    public class CloudCommunicationsGetPresencesByUserIdCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="ICloudCommunicationsGetPresencesByUserIdCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public ICloudCommunicationsGetPresencesByUserIdCollectionPage Value { get; set; }
        
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
