using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessApplications : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Can be one of the following:  The list of client IDs (appId) explicitly excluded from the policy. Office365 - For the list of apps included in Office365, see Conditional Access target apps: Office 365</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? ExcludeApplications {
            get { return BackingStore?.Get<List<string>?>("excludeApplications"); }
            set { BackingStore?.Set("excludeApplications", value); }
        }
#else
        public List<string> ExcludeApplications {
            get { return BackingStore?.Get<List<string>>("excludeApplications"); }
            set { BackingStore?.Set("excludeApplications", value); }
        }
#endif
        /// <summary>Can be one of the following:  The list of client IDs (appId) the policy applies to, unless explicitly excluded (in excludeApplications)  All  Office365 - For the list of apps included in Office365, see Conditional Access target apps: Office 365</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? IncludeApplications {
            get { return BackingStore?.Get<List<string>?>("includeApplications"); }
            set { BackingStore?.Set("includeApplications", value); }
        }
#else
        public List<string> IncludeApplications {
            get { return BackingStore?.Get<List<string>>("includeApplications"); }
            set { BackingStore?.Set("includeApplications", value); }
        }
#endif
        /// <summary>The includeAuthenticationContextClassReferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? IncludeAuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<string>?>("includeAuthenticationContextClassReferences"); }
            set { BackingStore?.Set("includeAuthenticationContextClassReferences", value); }
        }
#else
        public List<string> IncludeAuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<string>>("includeAuthenticationContextClassReferences"); }
            set { BackingStore?.Set("includeAuthenticationContextClassReferences", value); }
        }
#endif
        /// <summary>User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? IncludeUserActions {
            get { return BackingStore?.Get<List<string>?>("includeUserActions"); }
            set { BackingStore?.Set("includeUserActions", value); }
        }
#else
        public List<string> IncludeUserActions {
            get { return BackingStore?.Get<List<string>>("includeUserActions"); }
            set { BackingStore?.Set("includeUserActions", value); }
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
        /// Instantiates a new conditionalAccessApplications and sets the default values.
        /// </summary>
        public ConditionalAccessApplications() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessApplications CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessApplications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeApplications", n => { ExcludeApplications = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeApplications", n => { IncludeApplications = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeAuthenticationContextClassReferences", n => { IncludeAuthenticationContextClassReferences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeUserActions", n => { IncludeUserActions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeApplications", ExcludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeApplications", IncludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeAuthenticationContextClassReferences", IncludeAuthenticationContextClassReferences);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUserActions", IncludeUserActions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
