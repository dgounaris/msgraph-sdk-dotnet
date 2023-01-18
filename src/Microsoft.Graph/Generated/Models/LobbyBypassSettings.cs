using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class LobbyBypassSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies whether or not to always let dial-in callers bypass the lobby. Optional.</summary>
        public bool? IsDialInBypassEnabled {
            get { return BackingStore?.Get<bool?>("isDialInBypassEnabled"); }
            set { BackingStore?.Set("isDialInBypassEnabled", value); }
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
        /// <summary>Specifies the type of participants that are automatically admitted into a meeting, bypassing the lobby. Optional.</summary>
        public LobbyBypassScope? Scope {
            get { return BackingStore?.Get<LobbyBypassScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>
        /// Instantiates a new lobbyBypassSettings and sets the default values.
        /// </summary>
        public LobbyBypassSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LobbyBypassSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LobbyBypassSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isDialInBypassEnabled", n => { IsDialInBypassEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<LobbyBypassScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDialInBypassEnabled", IsDialInBypassEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<LobbyBypassScope>("scope", Scope);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
