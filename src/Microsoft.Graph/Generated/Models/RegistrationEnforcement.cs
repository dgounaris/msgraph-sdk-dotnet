using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class RegistrationEnforcement : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Run campaigns to remind users to set up targeted authentication methods.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign? AuthenticationMethodsRegistrationCampaign {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign?>("authenticationMethodsRegistrationCampaign"); }
            set { BackingStore?.Set("authenticationMethodsRegistrationCampaign", value); }
        }
#else
        public Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign AuthenticationMethodsRegistrationCampaign {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign>("authenticationMethodsRegistrationCampaign"); }
            set { BackingStore?.Set("authenticationMethodsRegistrationCampaign", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// Instantiates a new registrationEnforcement and sets the default values.
        /// </summary>
        public RegistrationEnforcement() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RegistrationEnforcement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistrationEnforcement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationMethodsRegistrationCampaign", n => { AuthenticationMethodsRegistrationCampaign = n.GetObjectValue<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign>(Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign>("authenticationMethodsRegistrationCampaign", AuthenticationMethodsRegistrationCampaign);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
