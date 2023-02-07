using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphExact {
    public class ExactPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The text1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Text1 {
            get { return BackingStore?.Get<Json?>("text1"); }
            set { BackingStore?.Set("text1", value); }
        }
#nullable restore
#else
        public Json Text1 {
            get { return BackingStore?.Get<Json>("text1"); }
            set { BackingStore?.Set("text1", value); }
        }
#endif
        /// <summary>The text2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Text2 {
            get { return BackingStore?.Get<Json?>("text2"); }
            set { BackingStore?.Set("text2", value); }
        }
#nullable restore
#else
        public Json Text2 {
            get { return BackingStore?.Get<Json>("text2"); }
            set { BackingStore?.Set("text2", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new exactPostRequestBody and sets the default values.
        /// </summary>
        public ExactPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExactPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"text1", n => { Text1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"text2", n => { Text2 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("text1", Text1);
            writer.WriteObjectValue<Json>("text2", Text2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
