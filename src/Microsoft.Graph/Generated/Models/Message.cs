using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Message : OutlookItem, IParsable {
        /// <summary>The fileAttachment and itemAttachment attachments for the message.</summary>
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
        /// <summary>The Bcc: recipients for the message.</summary>
        public List<Recipient> BccRecipients {
            get { return BackingStore?.Get<List<Recipient>>("bccRecipients"); }
            set { BackingStore?.Set("bccRecipients", value); }
        }
        /// <summary>The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
        /// <summary>The first 255 characters of the message body. It is in text format.</summary>
        public string BodyPreview {
            get { return BackingStore?.Get<string>("bodyPreview"); }
            set { BackingStore?.Set("bodyPreview", value); }
        }
        /// <summary>The Cc: recipients for the message.</summary>
        public List<Recipient> CcRecipients {
            get { return BackingStore?.Get<List<Recipient>>("ccRecipients"); }
            set { BackingStore?.Set("ccRecipients", value); }
        }
        /// <summary>The ID of the conversation the email belongs to.</summary>
        public string ConversationId {
            get { return BackingStore?.Get<string>("conversationId"); }
            set { BackingStore?.Set("conversationId", value); }
        }
        /// <summary>Indicates the position of the message within the conversation.</summary>
        public byte[] ConversationIndex {
            get { return BackingStore?.Get<byte[]>("conversationIndex"); }
            set { BackingStore?.Set("conversationIndex", value); }
        }
        /// <summary>The collection of open extensions defined for the message. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the message.</summary>
        public FollowupFlag Flag {
            get { return BackingStore?.Get<FollowupFlag>("flag"); }
            set { BackingStore?.Set("flag", value); }
        }
        /// <summary>The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
        public Recipient From {
            get { return BackingStore?.Get<Recipient>("from"); }
            set { BackingStore?.Set("from", value); }
        }
        /// <summary>Indicates whether the message has attachments. This property doesn&apos;t include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as &lt;IMG src=&apos;cid:image001.jpg@01D26CD8.6C05F070&apos;&gt;.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The inferenceClassification property</summary>
        public InferenceClassificationType? InferenceClassification {
            get { return BackingStore?.Get<InferenceClassificationType?>("inferenceClassification"); }
            set { BackingStore?.Set("inferenceClassification", value); }
        }
        /// <summary>The internetMessageHeaders property</summary>
        public List<InternetMessageHeader> InternetMessageHeaders {
            get { return BackingStore?.Get<List<InternetMessageHeader>>("internetMessageHeaders"); }
            set { BackingStore?.Set("internetMessageHeaders", value); }
        }
        /// <summary>The internetMessageId property</summary>
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
        /// <summary>The isDeliveryReceiptRequested property</summary>
        public bool? IsDeliveryReceiptRequested {
            get { return BackingStore?.Get<bool?>("isDeliveryReceiptRequested"); }
            set { BackingStore?.Set("isDeliveryReceiptRequested", value); }
        }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft {
            get { return BackingStore?.Get<bool?>("isDraft"); }
            set { BackingStore?.Set("isDraft", value); }
        }
        /// <summary>The isRead property</summary>
        public bool? IsRead {
            get { return BackingStore?.Get<bool?>("isRead"); }
            set { BackingStore?.Set("isRead", value); }
        }
        /// <summary>The isReadReceiptRequested property</summary>
        public bool? IsReadReceiptRequested {
            get { return BackingStore?.Get<bool?>("isReadReceiptRequested"); }
            set { BackingStore?.Set("isReadReceiptRequested", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the message. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
        /// <summary>The parentFolderId property</summary>
        public string ParentFolderId {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>The replyTo property</summary>
        public List<Recipient> ReplyTo {
            get { return BackingStore?.Get<List<Recipient>>("replyTo"); }
            set { BackingStore?.Set("replyTo", value); }
        }
        /// <summary>The sender property</summary>
        public Recipient Sender {
            get { return BackingStore?.Get<Recipient>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
        /// <summary>The sentDateTime property</summary>
        public DateTimeOffset? SentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sentDateTime"); }
            set { BackingStore?.Set("sentDateTime", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the message. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The toRecipients property</summary>
        public List<Recipient> ToRecipients {
            get { return BackingStore?.Get<List<Recipient>>("toRecipients"); }
            set { BackingStore?.Set("toRecipients", value); }
        }
        /// <summary>The uniqueBody property</summary>
        public ItemBody UniqueBody {
            get { return BackingStore?.Get<ItemBody>("uniqueBody"); }
            set { BackingStore?.Set("uniqueBody", value); }
        }
        /// <summary>The webLink property</summary>
        public string WebLink {
            get { return BackingStore?.Get<string>("webLink"); }
            set { BackingStore?.Set("webLink", value); }
        }
        /// <summary>
        /// Instantiates a new Message and sets the default values.
        /// </summary>
        public Message() : base() {
            OdataType = "#microsoft.graph.message";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Message CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.calendarSharingMessage" => new CalendarSharingMessage(),
                "#microsoft.graph.eventMessage" => new EventMessage(),
                "#microsoft.graph.eventMessageRequest" => new EventMessageRequest(),
                "#microsoft.graph.eventMessageResponse" => new EventMessageResponse(),
                _ => new Message(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bccRecipients", n => { BccRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"ccRecipients", n => { CcRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conversationId", n => { ConversationId = n.GetStringValue(); } },
                {"conversationIndex", n => { ConversationIndex = n.GetByteArrayValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"flag", n => { Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"inferenceClassification", n => { InferenceClassification = n.GetEnumValue<InferenceClassificationType>(); } },
                {"internetMessageHeaders", n => { InternetMessageHeaders = n.GetCollectionOfObjectValues<InternetMessageHeader>(InternetMessageHeader.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"isDeliveryReceiptRequested", n => { IsDeliveryReceiptRequested = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isRead", n => { IsRead = n.GetBoolValue(); } },
                {"isReadReceiptRequested", n => { IsReadReceiptRequested = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"replyTo", n => { ReplyTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sender", n => { Sender = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"sentDateTime", n => { SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"toRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"uniqueBody", n => { UniqueBody = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Recipient>("bccRecipients", BccRecipients);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteByteArrayValue("conversationIndex", ConversationIndex);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteEnumValue<InferenceClassificationType>("inferenceClassification", InferenceClassification);
            writer.WriteCollectionOfObjectValues<InternetMessageHeader>("internetMessageHeaders", InternetMessageHeaders);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteBoolValue("isDeliveryReceiptRequested", IsDeliveryReceiptRequested);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteBoolValue("isReadReceiptRequested", IsReadReceiptRequested);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<Recipient>("replyTo", ReplyTo);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteObjectValue<ItemBody>("uniqueBody", UniqueBody);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
