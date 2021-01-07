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
    /// The type Mac OSCompliance Policy.
    /// </summary>
    
    public partial class MacOSCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The MacOSCompliancePolicy constructor
		///</summary>
        public MacOSCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.macOSCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection.
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionEnabled")]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionRequiredSecurityLevel")]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets firewall block all incoming.
        /// Corresponds to the 'Block all incoming connections' option.
        /// </summary>
        [JsonPropertyName("firewallBlockAllIncoming")]
        public bool? FirewallBlockAllIncoming { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enabled.
        /// Whether the firewall should be enabled or not.
        /// </summary>
        [JsonPropertyName("firewallEnabled")]
        public bool? FirewallEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enable stealth mode.
        /// Corresponds to 'Enable stealth mode.'
        /// </summary>
        [JsonPropertyName("firewallEnableStealthMode")]
        public bool? FirewallEnableStealthMode { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum MacOS version.
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum MacOS version.
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Indicates whether or not to block simple passwords.
        /// </summary>
        [JsonPropertyName("passwordBlockSimple")]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 65535
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonPropertyName("passwordMinimumCharacterSetCount")]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of password. Valid values 4 to 14
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeLock")]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 1 to 24
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Whether or not to require a password.
        /// </summary>
        [JsonPropertyName("passwordRequired")]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on Mac OS devices.
        /// </summary>
        [JsonPropertyName("storageRequireEncryption")]
        public bool? StorageRequireEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets system integrity protection enabled.
        /// Require that devices have enabled system integrity protection.
        /// </summary>
        [JsonPropertyName("systemIntegrityProtectionEnabled")]
        public bool? SystemIntegrityProtectionEnabled { get; set; }
    
    }
}

