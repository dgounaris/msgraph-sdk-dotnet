using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PlannerTask : Entity, IParsable {
        /// <summary>Number of checklist items with value set to false, representing incomplete items.</summary>
        public int? ActiveChecklistItemCount {
            get { return BackingStore?.Get<int?>("activeChecklistItemCount"); }
            set { BackingStore?.Set("activeChecklistItemCount", value); }
        }
        /// <summary>The categories to which the task has been applied. See applied Categories for possible values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerAppliedCategories? AppliedCategories {
            get { return BackingStore?.Get<PlannerAppliedCategories?>("appliedCategories"); }
            set { BackingStore?.Set("appliedCategories", value); }
        }
#else
        public PlannerAppliedCategories AppliedCategories {
            get { return BackingStore?.Get<PlannerAppliedCategories>("appliedCategories"); }
            set { BackingStore?.Set("appliedCategories", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerAssignedToTaskBoardTaskFormat? AssignedToTaskBoardFormat {
            get { return BackingStore?.Get<PlannerAssignedToTaskBoardTaskFormat?>("assignedToTaskBoardFormat"); }
            set { BackingStore?.Set("assignedToTaskBoardFormat", value); }
        }
#else
        public PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat {
            get { return BackingStore?.Get<PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat"); }
            set { BackingStore?.Set("assignedToTaskBoardFormat", value); }
        }
#endif
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AssigneePriority {
            get { return BackingStore?.Get<string?>("assigneePriority"); }
            set { BackingStore?.Set("assigneePriority", value); }
        }
#else
        public string AssigneePriority {
            get { return BackingStore?.Get<string>("assigneePriority"); }
            set { BackingStore?.Set("assigneePriority", value); }
        }
#endif
        /// <summary>The set of assignees the task is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerAssignments? Assignments {
            get { return BackingStore?.Get<PlannerAssignments?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#else
        public PlannerAssignments Assignments {
            get { return BackingStore?.Get<PlannerAssignments>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? BucketId {
            get { return BackingStore?.Get<string?>("bucketId"); }
            set { BackingStore?.Set("bucketId", value); }
        }
#else
        public string BucketId {
            get { return BackingStore?.Get<string>("bucketId"); }
            set { BackingStore?.Set("bucketId", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerBucketTaskBoardTaskFormat? BucketTaskBoardFormat {
            get { return BackingStore?.Get<PlannerBucketTaskBoardTaskFormat?>("bucketTaskBoardFormat"); }
            set { BackingStore?.Set("bucketTaskBoardFormat", value); }
        }
#else
        public PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat {
            get { return BackingStore?.Get<PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat"); }
            set { BackingStore?.Set("bucketTaskBoardFormat", value); }
        }
#endif
        /// <summary>Number of checklist items that are present on the task.</summary>
        public int? ChecklistItemCount {
            get { return BackingStore?.Get<int?>("checklistItemCount"); }
            set { BackingStore?.Set("checklistItemCount", value); }
        }
        /// <summary>Identity of the user that completed the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IdentitySet? CompletedBy {
            get { return BackingStore?.Get<IdentitySet?>("completedBy"); }
            set { BackingStore?.Set("completedBy", value); }
        }
#else
        public IdentitySet CompletedBy {
            get { return BackingStore?.Get<IdentitySet>("completedBy"); }
            set { BackingStore?.Set("completedBy", value); }
        }
#endif
        /// <summary>Read-only. Date and time at which the &apos;percentComplete&apos; of the task is set to &apos;100&apos;. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ConversationThreadId {
            get { return BackingStore?.Get<string?>("conversationThreadId"); }
            set { BackingStore?.Set("conversationThreadId", value); }
        }
#else
        public string ConversationThreadId {
            get { return BackingStore?.Get<string>("conversationThreadId"); }
            set { BackingStore?.Set("conversationThreadId", value); }
        }
#endif
        /// <summary>Identity of the user that created the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Read-only. Nullable. Additional details about the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerTaskDetails? Details {
            get { return BackingStore?.Get<PlannerTaskDetails?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#else
        public PlannerTaskDetails Details {
            get { return BackingStore?.Get<PlannerTaskDetails>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
        /// <summary>Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.</summary>
        public bool? HasDescription {
            get { return BackingStore?.Get<bool?>("hasDescription"); }
            set { BackingStore?.Set("hasDescription", value); }
        }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OrderHint {
            get { return BackingStore?.Get<string?>("orderHint"); }
            set { BackingStore?.Set("orderHint", value); }
        }
#else
        public string OrderHint {
            get { return BackingStore?.Get<string>("orderHint"); }
            set { BackingStore?.Set("orderHint", value); }
        }
#endif
        /// <summary>Percentage of task completion. When set to 100, the task is considered completed.</summary>
        public int? PercentComplete {
            get { return BackingStore?.Get<int?>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
        /// <summary>Plan ID to which the task belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PlanId {
            get { return BackingStore?.Get<string?>("planId"); }
            set { BackingStore?.Set("planId", value); }
        }
#else
        public string PlanId {
            get { return BackingStore?.Get<string>("planId"); }
            set { BackingStore?.Set("planId", value); }
        }
#endif
        /// <summary>This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference.</summary>
        public PlannerPreviewType? PreviewType {
            get { return BackingStore?.Get<PlannerPreviewType?>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
        /// <summary>Priority of the task. The valid range of values is between 0 and 10, with the increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as &apos;urgent&apos;, 2, 3 and 4 as &apos;important&apos;, 5, 6, and 7 as &apos;medium&apos;, and 8, 9, and 10 as &apos;low&apos;.  Additionally, Planner sets the value 1 for &apos;urgent&apos;, 3 for &apos;important&apos;, 5 for &apos;medium&apos;, and 9 for &apos;low&apos;.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PlannerProgressTaskBoardTaskFormat? ProgressTaskBoardFormat {
            get { return BackingStore?.Get<PlannerProgressTaskBoardTaskFormat?>("progressTaskBoardFormat"); }
            set { BackingStore?.Set("progressTaskBoardFormat", value); }
        }
#else
        public PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat {
            get { return BackingStore?.Get<PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat"); }
            set { BackingStore?.Set("progressTaskBoardFormat", value); }
        }
#endif
        /// <summary>Number of external references that exist on the task.</summary>
        public int? ReferenceCount {
            get { return BackingStore?.Get<int?>("referenceCount"); }
            set { BackingStore?.Set("referenceCount", value); }
        }
        /// <summary>Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Title of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
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
        public static new PlannerTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeChecklistItemCount", n => { ActiveChecklistItemCount = n.GetIntValue(); } },
                {"appliedCategories", n => { AppliedCategories = n.GetObjectValue<PlannerAppliedCategories>(PlannerAppliedCategories.CreateFromDiscriminatorValue); } },
                {"assignedToTaskBoardFormat", n => { AssignedToTaskBoardFormat = n.GetObjectValue<PlannerAssignedToTaskBoardTaskFormat>(PlannerAssignedToTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"assigneePriority", n => { AssigneePriority = n.GetStringValue(); } },
                {"assignments", n => { Assignments = n.GetObjectValue<PlannerAssignments>(PlannerAssignments.CreateFromDiscriminatorValue); } },
                {"bucketId", n => { BucketId = n.GetStringValue(); } },
                {"bucketTaskBoardFormat", n => { BucketTaskBoardFormat = n.GetObjectValue<PlannerBucketTaskBoardTaskFormat>(PlannerBucketTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"checklistItemCount", n => { ChecklistItemCount = n.GetIntValue(); } },
                {"completedBy", n => { CompletedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", n => { Details = n.GetObjectValue<PlannerTaskDetails>(PlannerTaskDetails.CreateFromDiscriminatorValue); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"hasDescription", n => { HasDescription = n.GetBoolValue(); } },
                {"orderHint", n => { OrderHint = n.GetStringValue(); } },
                {"percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                {"planId", n => { PlanId = n.GetStringValue(); } },
                {"previewType", n => { PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"progressTaskBoardFormat", n => { ProgressTaskBoardFormat = n.GetObjectValue<PlannerProgressTaskBoardTaskFormat>(PlannerProgressTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"referenceCount", n => { ReferenceCount = n.GetIntValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteIntValue("activeChecklistItemCount", ActiveChecklistItemCount);
            writer.WriteObjectValue<PlannerAppliedCategories>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat", AssignedToTaskBoardFormat);
            writer.WriteStringValue("assigneePriority", AssigneePriority);
            writer.WriteObjectValue<PlannerAssignments>("assignments", Assignments);
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteObjectValue<PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat", BucketTaskBoardFormat);
            writer.WriteIntValue("checklistItemCount", ChecklistItemCount);
            writer.WriteObjectValue<IdentitySet>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerTaskDetails>("details", Details);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasDescription", HasDescription);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat", ProgressTaskBoardFormat);
            writer.WriteIntValue("referenceCount", ReferenceCount);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
