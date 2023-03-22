using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class Alert : Entity, IParsable {
        /// <summary>The adversary or activity group that is associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActorDisplayName {
            get { return BackingStore?.Get<string?>("actorDisplayName"); }
            set { BackingStore?.Set("actorDisplayName", value); }
        }
#nullable restore
#else
        public string ActorDisplayName {
            get { return BackingStore?.Get<string>("actorDisplayName"); }
            set { BackingStore?.Set("actorDisplayName", value); }
        }
#endif
        /// <summary>URL for the alert page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertWebUrl {
            get { return BackingStore?.Get<string?>("alertWebUrl"); }
            set { BackingStore?.Set("alertWebUrl", value); }
        }
#nullable restore
#else
        public string AlertWebUrl {
            get { return BackingStore?.Get<string>("alertWebUrl"); }
            set { BackingStore?.Set("alertWebUrl", value); }
        }
#endif
        /// <summary>Owner of the alert, or null if no owner is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo {
            get { return BackingStore?.Get<string?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public string AssignedTo {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Specifies whether the alert represents a true threat. Possible values are: unknown, falsePositive, truePositive, benignPositive, unknownFutureValue.</summary>
        public AlertClassification? Classification {
            get { return BackingStore?.Get<AlertClassification?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>Array of comments created by the Security Operations (SecOps) team during the alert management process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertComment>? Comments {
            get { return BackingStore?.Get<List<AlertComment>?>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#nullable restore
#else
        public List<AlertComment> Comments {
            get { return BackingStore?.Get<List<AlertComment>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#endif
        /// <summary>Time when Microsoft 365 Defender created the alert.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>String value describing each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Detection technology or sensor that identified the notable component or activity.</summary>
        public Microsoft.Graph.Models.Security.DetectionSource? DetectionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.DetectionSource?>("detectionSource"); }
            set { BackingStore?.Set("detectionSource", value); }
        }
        /// <summary>The ID of the detector that triggered the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectorId {
            get { return BackingStore?.Get<string?>("detectorId"); }
            set { BackingStore?.Set("detectorId", value); }
        }
#nullable restore
#else
        public string DetectorId {
            get { return BackingStore?.Get<string>("detectorId"); }
            set { BackingStore?.Set("detectorId", value); }
        }
#endif
        /// <summary>Specifies the result of the investigation, whether the alert represents a true attack and if so, the nature of the attack. Possible values are: unknown, apt, malware, securityPersonnel, securityTesting, unwantedSoftware, other, multiStagedAttack, compromisedUser, phishing, maliciousUserActivity, clean, insufficientData, confirmedUserActivity, lineOfBusinessApplication, unknownFutureValue.</summary>
        public AlertDetermination? Determination {
            get { return BackingStore?.Get<AlertDetermination?>("determination"); }
            set { BackingStore?.Set("determination", value); }
        }
        /// <summary>Collection of evidence related to the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertEvidence>? Evidence {
            get { return BackingStore?.Get<List<AlertEvidence>?>("evidence"); }
            set { BackingStore?.Set("evidence", value); }
        }
#nullable restore
#else
        public List<AlertEvidence> Evidence {
            get { return BackingStore?.Get<List<AlertEvidence>>("evidence"); }
            set { BackingStore?.Set("evidence", value); }
        }
#endif
        /// <summary>The earliest activity associated with the alert.</summary>
        public DateTimeOffset? FirstActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstActivityDateTime"); }
            set { BackingStore?.Set("firstActivityDateTime", value); }
        }
        /// <summary>Unique identifier to represent the incident this alert resource is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentId {
            get { return BackingStore?.Get<string?>("incidentId"); }
            set { BackingStore?.Set("incidentId", value); }
        }
#nullable restore
#else
        public string IncidentId {
            get { return BackingStore?.Get<string>("incidentId"); }
            set { BackingStore?.Set("incidentId", value); }
        }
#endif
        /// <summary>URL for the incident page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentWebUrl {
            get { return BackingStore?.Get<string?>("incidentWebUrl"); }
            set { BackingStore?.Set("incidentWebUrl", value); }
        }
#nullable restore
#else
        public string IncidentWebUrl {
            get { return BackingStore?.Get<string>("incidentWebUrl"); }
            set { BackingStore?.Set("incidentWebUrl", value); }
        }
#endif
        /// <summary>The oldest activity associated with the alert.</summary>
        public DateTimeOffset? LastActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActivityDateTime"); }
            set { BackingStore?.Set("lastActivityDateTime", value); }
        }
        /// <summary>Time when the alert was last updated at Microsoft 365 Defender.</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The attack techniques, as aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MitreTechniques {
            get { return BackingStore?.Get<List<string>?>("mitreTechniques"); }
            set { BackingStore?.Set("mitreTechniques", value); }
        }
#nullable restore
#else
        public List<string> MitreTechniques {
            get { return BackingStore?.Get<List<string>>("mitreTechniques"); }
            set { BackingStore?.Set("mitreTechniques", value); }
        }
#endif
        /// <summary>The ID of the alert as it appears in the security provider product that generated the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderAlertId {
            get { return BackingStore?.Get<string?>("providerAlertId"); }
            set { BackingStore?.Set("providerAlertId", value); }
        }
#nullable restore
#else
        public string ProviderAlertId {
            get { return BackingStore?.Get<string>("providerAlertId"); }
            set { BackingStore?.Set("providerAlertId", value); }
        }
#endif
        /// <summary>Recommended response and remediation actions to take in the event this alert was generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedActions {
            get { return BackingStore?.Get<string?>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#nullable restore
#else
        public string RecommendedActions {
            get { return BackingStore?.Get<string>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#endif
        /// <summary>Time when the alert was resolved.</summary>
        public DateTimeOffset? ResolvedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedDateTime"); }
            set { BackingStore?.Set("resolvedDateTime", value); }
        }
        /// <summary>The serviceSource property</summary>
        public Microsoft.Graph.Models.Security.ServiceSource? ServiceSource {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.ServiceSource?>("serviceSource"); }
            set { BackingStore?.Set("serviceSource", value); }
        }
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public AlertStatus? Status {
            get { return BackingStore?.Get<AlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The Azure Active Directory tenant the alert was created in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The threat associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatDisplayName {
            get { return BackingStore?.Get<string?>("threatDisplayName"); }
            set { BackingStore?.Set("threatDisplayName", value); }
        }
#nullable restore
#else
        public string ThreatDisplayName {
            get { return BackingStore?.Get<string>("threatDisplayName"); }
            set { BackingStore?.Set("threatDisplayName", value); }
        }
#endif
        /// <summary>Threat family associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatFamilyName {
            get { return BackingStore?.Get<string?>("threatFamilyName"); }
            set { BackingStore?.Set("threatFamilyName", value); }
        }
#nullable restore
#else
        public string ThreatFamilyName {
            get { return BackingStore?.Get<string>("threatFamilyName"); }
            set { BackingStore?.Set("threatFamilyName", value); }
        }
#endif
        /// <summary>Brief identifying string value describing the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Alert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actorDisplayName", n => { ActorDisplayName = n.GetStringValue(); } },
                {"alertWebUrl", n => { AlertWebUrl = n.GetStringValue(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"classification", n => { Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<AlertComment>(AlertComment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionSource", n => { DetectionSource = n.GetEnumValue<DetectionSource>(); } },
                {"detectorId", n => { DetectorId = n.GetStringValue(); } },
                {"determination", n => { Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"evidence", n => { Evidence = n.GetCollectionOfObjectValues<AlertEvidence>(AlertEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"firstActivityDateTime", n => { FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"incidentId", n => { IncidentId = n.GetStringValue(); } },
                {"incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                {"lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"mitreTechniques", n => { MitreTechniques = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"providerAlertId", n => { ProviderAlertId = n.GetStringValue(); } },
                {"recommendedActions", n => { RecommendedActions = n.GetStringValue(); } },
                {"resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"serviceSource", n => { ServiceSource = n.GetEnumValue<ServiceSource>(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"threatDisplayName", n => { ThreatDisplayName = n.GetStringValue(); } },
                {"threatFamilyName", n => { ThreatFamilyName = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actorDisplayName", ActorDisplayName);
            writer.WriteStringValue("alertWebUrl", AlertWebUrl);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("category", Category);
            writer.WriteEnumValue<AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DetectionSource>("detectionSource", DetectionSource);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteEnumValue<AlertDetermination>("determination", Determination);
            writer.WriteCollectionOfObjectValues<AlertEvidence>("evidence", Evidence);
            writer.WriteDateTimeOffsetValue("firstActivityDateTime", FirstActivityDateTime);
            writer.WriteStringValue("incidentId", IncidentId);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("mitreTechniques", MitreTechniques);
            writer.WriteStringValue("providerAlertId", ProviderAlertId);
            writer.WriteStringValue("recommendedActions", RecommendedActions);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<ServiceSource>("serviceSource", ServiceSource);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatDisplayName", ThreatDisplayName);
            writer.WriteStringValue("threatFamilyName", ThreatFamilyName);
            writer.WriteStringValue("title", Title);
        }
    }
}