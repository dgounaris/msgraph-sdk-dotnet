using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessGrantControls : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ConditionalAccessGrantControl?>? BuiltInControls {
            get { return BackingStore?.Get<List<ConditionalAccessGrantControl?>?>("builtInControls"); }
            set { BackingStore?.Set("builtInControls", value); }
        }
#else
        public List<ConditionalAccessGrantControl?> BuiltInControls {
            get { return BackingStore?.Get<List<ConditionalAccessGrantControl?>>("builtInControls"); }
            set { BackingStore?.Set("builtInControls", value); }
        }
#endif
        /// <summary>List of custom controls IDs required by the policy. For more information, see Custom controls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? CustomAuthenticationFactors {
            get { return BackingStore?.Get<List<string>?>("customAuthenticationFactors"); }
            set { BackingStore?.Set("customAuthenticationFactors", value); }
        }
#else
        public List<string> CustomAuthenticationFactors {
            get { return BackingStore?.Get<List<string>>("customAuthenticationFactors"); }
            set { BackingStore?.Set("customAuthenticationFactors", value); }
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
        /// <summary>Defines the relationship of the grant controls. Possible values: AND, OR.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Operator {
            get { return BackingStore?.Get<string?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#else
        public string Operator {
            get { return BackingStore?.Get<string>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#endif
        /// <summary>List of terms of use IDs required by the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? TermsOfUse {
            get { return BackingStore?.Get<List<string>?>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#else
        public List<string> TermsOfUse {
            get { return BackingStore?.Get<List<string>>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessGrantControls and sets the default values.
        /// </summary>
        public ConditionalAccessGrantControls() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessGrantControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessGrantControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"builtInControls", n => { BuiltInControls = n.GetCollectionOfEnumValues<ConditionalAccessGrantControl>()?.ToList(); } },
                {"customAuthenticationFactors", n => { CustomAuthenticationFactors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"termsOfUse", n => { TermsOfUse = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ConditionalAccessGrantControl>("builtInControls", BuiltInControls);
            writer.WriteCollectionOfPrimitiveValues<string>("customAuthenticationFactors", CustomAuthenticationFactors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteCollectionOfPrimitiveValues<string>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
