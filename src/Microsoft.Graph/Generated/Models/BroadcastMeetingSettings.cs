using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class BroadcastMeetingSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Defines who can join the Teams live event. Possible values are listed in the following table.</summary>
        public BroadcastMeetingAudience? AllowedAudience {
            get { return BackingStore?.Get<BroadcastMeetingAudience?>("allowedAudience"); }
            set { BackingStore?.Set("allowedAudience", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Caption settings of a Teams live event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BroadcastMeetingCaptionSettings? Captions {
            get { return BackingStore?.Get<BroadcastMeetingCaptionSettings?>("captions"); }
            set { BackingStore?.Set("captions", value); }
        }
#nullable restore
#else
        public BroadcastMeetingCaptionSettings Captions {
            get { return BackingStore?.Get<BroadcastMeetingCaptionSettings>("captions"); }
            set { BackingStore?.Set("captions", value); }
        }
#endif
        /// <summary>Indicates whether attendee report is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsAttendeeReportEnabled {
            get { return BackingStore?.Get<bool?>("isAttendeeReportEnabled"); }
            set { BackingStore?.Set("isAttendeeReportEnabled", value); }
        }
        /// <summary>Indicates whether Q&amp;A is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsQuestionAndAnswerEnabled {
            get { return BackingStore?.Get<bool?>("isQuestionAndAnswerEnabled"); }
            set { BackingStore?.Set("isQuestionAndAnswerEnabled", value); }
        }
        /// <summary>Indicates whether recording is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsRecordingEnabled {
            get { return BackingStore?.Get<bool?>("isRecordingEnabled"); }
            set { BackingStore?.Set("isRecordingEnabled", value); }
        }
        /// <summary>Indicates whether video on demand is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsVideoOnDemandEnabled {
            get { return BackingStore?.Get<bool?>("isVideoOnDemandEnabled"); }
            set { BackingStore?.Set("isVideoOnDemandEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new broadcastMeetingSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BroadcastMeetingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BroadcastMeetingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedAudience", n => { AllowedAudience = n.GetEnumValue<BroadcastMeetingAudience>(); } },
                {"captions", n => { Captions = n.GetObjectValue<BroadcastMeetingCaptionSettings>(BroadcastMeetingCaptionSettings.CreateFromDiscriminatorValue); } },
                {"isAttendeeReportEnabled", n => { IsAttendeeReportEnabled = n.GetBoolValue(); } },
                {"isQuestionAndAnswerEnabled", n => { IsQuestionAndAnswerEnabled = n.GetBoolValue(); } },
                {"isRecordingEnabled", n => { IsRecordingEnabled = n.GetBoolValue(); } },
                {"isVideoOnDemandEnabled", n => { IsVideoOnDemandEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BroadcastMeetingAudience>("allowedAudience", AllowedAudience);
            writer.WriteObjectValue<BroadcastMeetingCaptionSettings>("captions", Captions);
            writer.WriteBoolValue("isAttendeeReportEnabled", IsAttendeeReportEnabled);
            writer.WriteBoolValue("isQuestionAndAnswerEnabled", IsQuestionAndAnswerEnabled);
            writer.WriteBoolValue("isRecordingEnabled", IsRecordingEnabled);
            writer.WriteBoolValue("isVideoOnDemandEnabled", IsVideoOnDemandEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}