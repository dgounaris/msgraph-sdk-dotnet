using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ServiceHealthIssue : ServiceAnnouncementBase, IParsable {
        /// <summary>The classification property</summary>
        public ServiceHealthClassificationType? Classification {
            get { return BackingStore?.Get<ServiceHealthClassificationType?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>The feature name of the service issue.</summary>
        public string Feature {
            get { return BackingStore?.Get<string>("feature"); }
            set { BackingStore?.Set("feature", value); }
        }
        /// <summary>The feature group name of the service issue.</summary>
        public string FeatureGroup {
            get { return BackingStore?.Get<string>("featureGroup"); }
            set { BackingStore?.Set("featureGroup", value); }
        }
        /// <summary>The description of the service issue impact.</summary>
        public string ImpactDescription {
            get { return BackingStore?.Get<string>("impactDescription"); }
            set { BackingStore?.Set("impactDescription", value); }
        }
        /// <summary>Indicates whether the issue is resolved.</summary>
        public bool? IsResolved {
            get { return BackingStore?.Get<bool?>("isResolved"); }
            set { BackingStore?.Set("isResolved", value); }
        }
        /// <summary>The origin property</summary>
        public ServiceHealthOrigin? Origin {
            get { return BackingStore?.Get<ServiceHealthOrigin?>("origin"); }
            set { BackingStore?.Set("origin", value); }
        }
        /// <summary>Collection of historical posts for the service issue.</summary>
        public List<ServiceHealthIssuePost> Posts {
            get { return BackingStore?.Get<List<ServiceHealthIssuePost>>("posts"); }
            set { BackingStore?.Set("posts", value); }
        }
        /// <summary>Indicates the service affected by the issue.</summary>
        public string Service {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
        /// <summary>The status property</summary>
        public ServiceHealthStatus? Status {
            get { return BackingStore?.Get<ServiceHealthStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new ServiceHealthIssue and sets the default values.
        /// </summary>
        public ServiceHealthIssue() : base() {
            OdataType = "#microsoft.graph.serviceHealthIssue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServiceHealthIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classification", n => { Classification = n.GetEnumValue<ServiceHealthClassificationType>(); } },
                {"feature", n => { Feature = n.GetStringValue(); } },
                {"featureGroup", n => { FeatureGroup = n.GetStringValue(); } },
                {"impactDescription", n => { ImpactDescription = n.GetStringValue(); } },
                {"isResolved", n => { IsResolved = n.GetBoolValue(); } },
                {"origin", n => { Origin = n.GetEnumValue<ServiceHealthOrigin>(); } },
                {"posts", n => { Posts = n.GetCollectionOfObjectValues<ServiceHealthIssuePost>(ServiceHealthIssuePost.CreateFromDiscriminatorValue).ToList(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ServiceHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ServiceHealthClassificationType>("classification", Classification);
            writer.WriteStringValue("feature", Feature);
            writer.WriteStringValue("featureGroup", FeatureGroup);
            writer.WriteStringValue("impactDescription", ImpactDescription);
            writer.WriteBoolValue("isResolved", IsResolved);
            writer.WriteEnumValue<ServiceHealthOrigin>("origin", Origin);
            writer.WriteCollectionOfObjectValues<ServiceHealthIssuePost>("posts", Posts);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<ServiceHealthStatus>("status", Status);
        }
    }
}
