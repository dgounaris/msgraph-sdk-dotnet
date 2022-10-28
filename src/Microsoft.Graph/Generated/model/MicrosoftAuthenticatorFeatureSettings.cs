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
    /// The type MicrosoftAuthenticatorFeatureSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MicrosoftAuthenticatorFeatureSettings>))]
    public partial class MicrosoftAuthenticatorFeatureSettings
    {

        /// <summary>
        /// Gets or sets displayAppInformationRequiredState.
        /// Determines whether the user's Authenticator app will show them the client app they are signing into.
        /// </summary>
        [JsonPropertyName("displayAppInformationRequiredState")]
        public AuthenticationMethodFeatureConfiguration DisplayAppInformationRequiredState { get; set; }
    
        /// <summary>
        /// Gets or sets displayLocationInformationRequiredState.
        /// Determines whether the user's Authenticator app will show them the geographic location of where the authentication request originated from.
        /// </summary>
        [JsonPropertyName("displayLocationInformationRequiredState")]
        public AuthenticationMethodFeatureConfiguration DisplayLocationInformationRequiredState { get; set; }
    
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