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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type InvitationParticipantInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class InvitationParticipantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationParticipantInfo"/> class.
        /// </summary>
        public InvitationParticipantInfo()
        {
            this.ODataType = "microsoft.graph.invitationParticipantInfo";
        }

        /// <summary>
        /// Gets or sets identity.
        /// The identitySet associated with this invitation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identity", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets replacesCallId.
        /// Optional. The call which the target idenity is currently a part of. This call will be dropped once the participant is added.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replacesCallId", Required = Newtonsoft.Json.Required.Default)]
        public string ReplacesCallId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
