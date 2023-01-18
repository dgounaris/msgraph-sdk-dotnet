using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessReviewHistoryScheduleSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
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
        /// <summary>The recurrence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PatternedRecurrence? Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#else
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#endif
        /// <summary>A duration string in ISO 8601 duration format specifying the lookback period of the generated review history data. For example, if a history definition is scheduled to run on the 1st of every month, the reportRange is P1M. In this case, on the first of every month, access review history data will be collected containing only the previous month&apos;s review data. Note: Only years, months, and days ISO 8601 properties are supported. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ReportRange {
            get { return BackingStore?.Get<string?>("reportRange"); }
            set { BackingStore?.Set("reportRange", value); }
        }
#else
        public string ReportRange {
            get { return BackingStore?.Get<string>("reportRange"); }
            set { BackingStore?.Set("reportRange", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new accessReviewHistoryScheduleSettings and sets the default values.
        /// </summary>
        public AccessReviewHistoryScheduleSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessReviewHistoryScheduleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewHistoryScheduleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reportRange", n => { ReportRange = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteStringValue("reportRange", ReportRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
