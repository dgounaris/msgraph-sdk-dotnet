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
    /// The type MediaContentRatingFrance.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MediaContentRatingFrance>))]
    public partial class MediaContentRatingFrance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContentRatingFrance"/> class.
        /// </summary>
        public MediaContentRatingFrance()
        {
            this.ODataType = "microsoft.graph.mediaContentRatingFrance";
        }

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for France. Possible values are: allAllowed, allBlocked, agesAbove10, agesAbove12, agesAbove16, agesAbove18.
        /// </summary>
        [JsonPropertyName("movieRating")]
        public RatingFranceMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for France. Possible values are: allAllowed, allBlocked, agesAbove10, agesAbove12, agesAbove16, agesAbove18.
        /// </summary>
        [JsonPropertyName("tvRating")]
        public RatingFranceTelevisionType? TvRating { get; set; }
    
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
