// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum OnlineMeetingRole.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OnlineMeetingRole
    {
    
        /// <summary>
        /// Attendee
        /// </summary>
        Attendee = 0,
	
        /// <summary>
        /// Presenter
        /// </summary>
        Presenter = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
        /// <summary>
        /// Producer
        /// </summary>
        Producer = 3,
	
        /// <summary>
        /// Coorganizer
        /// </summary>
        Coorganizer = 4,
	
    }
}
