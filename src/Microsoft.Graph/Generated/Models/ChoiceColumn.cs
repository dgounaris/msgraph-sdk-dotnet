using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChoiceColumn : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>If true, allows custom values that aren&apos;t in the configured choices.</summary>
        public bool? AllowTextEntry {
            get { return BackingStore?.Get<bool?>("allowTextEntry"); }
            set { BackingStore?.Set("allowTextEntry", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of values available for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? Choices {
            get { return BackingStore?.Get<List<string>?>("choices"); }
            set { BackingStore?.Set("choices", value); }
        }
#else
        public List<string> Choices {
            get { return BackingStore?.Get<List<string>>("choices"); }
            set { BackingStore?.Set("choices", value); }
        }
#endif
        /// <summary>How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayAs {
            get { return BackingStore?.Get<string?>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
        }
#else
        public string DisplayAs {
            get { return BackingStore?.Get<string>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new choiceColumn and sets the default values.
        /// </summary>
        public ChoiceColumn() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChoiceColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChoiceColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowTextEntry", n => { AllowTextEntry = n.GetBoolValue(); } },
                {"choices", n => { Choices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"displayAs", n => { DisplayAs = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowTextEntry", AllowTextEntry);
            writer.WriteCollectionOfPrimitiveValues<string>("choices", Choices);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
