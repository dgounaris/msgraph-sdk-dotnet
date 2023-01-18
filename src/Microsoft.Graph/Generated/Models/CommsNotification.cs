using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class CommsNotification : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The changeType property</summary>
        public Microsoft.Graph.Models.ChangeType? ChangeType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChangeType?>("changeType"); }
            set { BackingStore?.Set("changeType", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>URI of the resource that was changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ResourceUrl {
            get { return BackingStore?.Get<string?>("resourceUrl"); }
            set { BackingStore?.Set("resourceUrl", value); }
        }
#else
        public string ResourceUrl {
            get { return BackingStore?.Get<string>("resourceUrl"); }
            set { BackingStore?.Set("resourceUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new commsNotification and sets the default values.
        /// </summary>
        public CommsNotification() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CommsNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommsNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"changeType", n => { ChangeType = n.GetEnumValue<ChangeType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resourceUrl", n => { ResourceUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ChangeType>("changeType", ChangeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resourceUrl", ResourceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
