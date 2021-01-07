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
    /// The type FileHash.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<FileHash>))]
    public partial class FileHash
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileHash"/> class.
        /// </summary>
        public FileHash()
        {
            this.ODataType = "microsoft.graph.fileHash";
        }

        /// <summary>
        /// Gets or sets hashType.
        /// File hash type. Possible values are: unknown, sha1, sha256, md5, authenticodeHash256, lsHash, ctph, peSha1, peSha256.
        /// </summary>
        [JsonPropertyName("hashType")]
        public FileHashType? HashType { get; set; }
    
        /// <summary>
        /// Gets or sets hashValue.
        /// Value of the file hash.
        /// </summary>
        [JsonPropertyName("hashValue")]
        public string HashValue { get; set; }
    
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
