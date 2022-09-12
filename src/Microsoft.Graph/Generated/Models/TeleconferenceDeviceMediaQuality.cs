using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TeleconferenceDeviceMediaQuality : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The average inbound stream network jitter.</summary>
        public TimeSpan? AverageInboundJitter {
            get { return BackingStore?.Get<TimeSpan?>("averageInboundJitter"); }
            set { BackingStore?.Set("averageInboundJitter", value); }
        }
        /// <summary>The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageInboundPacketLossRateInPercentage {
            get { return BackingStore?.Get<double?>("averageInboundPacketLossRateInPercentage"); }
            set { BackingStore?.Set("averageInboundPacketLossRateInPercentage", value); }
        }
        /// <summary>The average inbound stream network round trip delay.</summary>
        public TimeSpan? AverageInboundRoundTripDelay {
            get { return BackingStore?.Get<TimeSpan?>("averageInboundRoundTripDelay"); }
            set { BackingStore?.Set("averageInboundRoundTripDelay", value); }
        }
        /// <summary>The average outbound stream network jitter.</summary>
        public TimeSpan? AverageOutboundJitter {
            get { return BackingStore?.Get<TimeSpan?>("averageOutboundJitter"); }
            set { BackingStore?.Set("averageOutboundJitter", value); }
        }
        /// <summary>The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageOutboundPacketLossRateInPercentage {
            get { return BackingStore?.Get<double?>("averageOutboundPacketLossRateInPercentage"); }
            set { BackingStore?.Set("averageOutboundPacketLossRateInPercentage", value); }
        }
        /// <summary>The average outbound stream network round trip delay.</summary>
        public TimeSpan? AverageOutboundRoundTripDelay {
            get { return BackingStore?.Get<TimeSpan?>("averageOutboundRoundTripDelay"); }
            set { BackingStore?.Set("averageOutboundRoundTripDelay", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.</summary>
        public int? ChannelIndex {
            get { return BackingStore?.Get<int?>("channelIndex"); }
            set { BackingStore?.Set("channelIndex", value); }
        }
        /// <summary>The total number of the inbound packets.</summary>
        public long? InboundPackets {
            get { return BackingStore?.Get<long?>("inboundPackets"); }
            set { BackingStore?.Set("inboundPackets", value); }
        }
        /// <summary>the local IP address for the media session.</summary>
        public string LocalIPAddress {
            get { return BackingStore?.Get<string>("localIPAddress"); }
            set { BackingStore?.Set("localIPAddress", value); }
        }
        /// <summary>The local media port.</summary>
        public int? LocalPort {
            get { return BackingStore?.Get<int?>("localPort"); }
            set { BackingStore?.Set("localPort", value); }
        }
        /// <summary>The maximum inbound stream network jitter.</summary>
        public TimeSpan? MaximumInboundJitter {
            get { return BackingStore?.Get<TimeSpan?>("maximumInboundJitter"); }
            set { BackingStore?.Set("maximumInboundJitter", value); }
        }
        /// <summary>The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumInboundPacketLossRateInPercentage {
            get { return BackingStore?.Get<double?>("maximumInboundPacketLossRateInPercentage"); }
            set { BackingStore?.Set("maximumInboundPacketLossRateInPercentage", value); }
        }
        /// <summary>The maximum inbound stream network round trip delay.</summary>
        public TimeSpan? MaximumInboundRoundTripDelay {
            get { return BackingStore?.Get<TimeSpan?>("maximumInboundRoundTripDelay"); }
            set { BackingStore?.Set("maximumInboundRoundTripDelay", value); }
        }
        /// <summary>The maximum outbound stream network jitter.</summary>
        public TimeSpan? MaximumOutboundJitter {
            get { return BackingStore?.Get<TimeSpan?>("maximumOutboundJitter"); }
            set { BackingStore?.Set("maximumOutboundJitter", value); }
        }
        /// <summary>The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumOutboundPacketLossRateInPercentage {
            get { return BackingStore?.Get<double?>("maximumOutboundPacketLossRateInPercentage"); }
            set { BackingStore?.Set("maximumOutboundPacketLossRateInPercentage", value); }
        }
        /// <summary>The maximum outbound stream network round trip delay.</summary>
        public TimeSpan? MaximumOutboundRoundTripDelay {
            get { return BackingStore?.Get<TimeSpan?>("maximumOutboundRoundTripDelay"); }
            set { BackingStore?.Set("maximumOutboundRoundTripDelay", value); }
        }
        /// <summary>The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.</summary>
        public TimeSpan? MediaDuration {
            get { return BackingStore?.Get<TimeSpan?>("mediaDuration"); }
            set { BackingStore?.Set("mediaDuration", value); }
        }
        /// <summary>The network link speed in bytes</summary>
        public long? NetworkLinkSpeedInBytes {
            get { return BackingStore?.Get<long?>("networkLinkSpeedInBytes"); }
            set { BackingStore?.Set("networkLinkSpeedInBytes", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The total number of the outbound packets.</summary>
        public long? OutboundPackets {
            get { return BackingStore?.Get<long?>("outboundPackets"); }
            set { BackingStore?.Set("outboundPackets", value); }
        }
        /// <summary>The remote IP address for the media session.</summary>
        public string RemoteIPAddress {
            get { return BackingStore?.Get<string>("remoteIPAddress"); }
            set { BackingStore?.Set("remoteIPAddress", value); }
        }
        /// <summary>The remote media port.</summary>
        public int? RemotePort {
            get { return BackingStore?.Get<int?>("remotePort"); }
            set { BackingStore?.Set("remotePort", value); }
        }
        /// <summary>
        /// Instantiates a new teleconferenceDeviceMediaQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceMediaQuality() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teleconferenceDeviceMediaQuality";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeleconferenceDeviceMediaQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.teleconferenceDeviceAudioQuality" => new TeleconferenceDeviceAudioQuality(),
                "#microsoft.graph.teleconferenceDeviceScreenSharingQuality" => new TeleconferenceDeviceScreenSharingQuality(),
                "#microsoft.graph.teleconferenceDeviceVideoQuality" => new TeleconferenceDeviceVideoQuality(),
                _ => new TeleconferenceDeviceMediaQuality(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"averageInboundJitter", n => { AverageInboundJitter = n.GetTimeSpanValue(); } },
                {"averageInboundPacketLossRateInPercentage", n => { AverageInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageInboundRoundTripDelay", n => { AverageInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"averageOutboundJitter", n => { AverageOutboundJitter = n.GetTimeSpanValue(); } },
                {"averageOutboundPacketLossRateInPercentage", n => { AverageOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageOutboundRoundTripDelay", n => { AverageOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"channelIndex", n => { ChannelIndex = n.GetIntValue(); } },
                {"inboundPackets", n => { InboundPackets = n.GetLongValue(); } },
                {"localIPAddress", n => { LocalIPAddress = n.GetStringValue(); } },
                {"localPort", n => { LocalPort = n.GetIntValue(); } },
                {"maximumInboundJitter", n => { MaximumInboundJitter = n.GetTimeSpanValue(); } },
                {"maximumInboundPacketLossRateInPercentage", n => { MaximumInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumInboundRoundTripDelay", n => { MaximumInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"maximumOutboundJitter", n => { MaximumOutboundJitter = n.GetTimeSpanValue(); } },
                {"maximumOutboundPacketLossRateInPercentage", n => { MaximumOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumOutboundRoundTripDelay", n => { MaximumOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"mediaDuration", n => { MediaDuration = n.GetTimeSpanValue(); } },
                {"networkLinkSpeedInBytes", n => { NetworkLinkSpeedInBytes = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"outboundPackets", n => { OutboundPackets = n.GetLongValue(); } },
                {"remoteIPAddress", n => { RemoteIPAddress = n.GetStringValue(); } },
                {"remotePort", n => { RemotePort = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("averageInboundJitter", AverageInboundJitter);
            writer.WriteDoubleValue("averageInboundPacketLossRateInPercentage", AverageInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageInboundRoundTripDelay", AverageInboundRoundTripDelay);
            writer.WriteTimeSpanValue("averageOutboundJitter", AverageOutboundJitter);
            writer.WriteDoubleValue("averageOutboundPacketLossRateInPercentage", AverageOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageOutboundRoundTripDelay", AverageOutboundRoundTripDelay);
            writer.WriteIntValue("channelIndex", ChannelIndex);
            writer.WriteLongValue("inboundPackets", InboundPackets);
            writer.WriteStringValue("localIPAddress", LocalIPAddress);
            writer.WriteIntValue("localPort", LocalPort);
            writer.WriteTimeSpanValue("maximumInboundJitter", MaximumInboundJitter);
            writer.WriteDoubleValue("maximumInboundPacketLossRateInPercentage", MaximumInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumInboundRoundTripDelay", MaximumInboundRoundTripDelay);
            writer.WriteTimeSpanValue("maximumOutboundJitter", MaximumOutboundJitter);
            writer.WriteDoubleValue("maximumOutboundPacketLossRateInPercentage", MaximumOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumOutboundRoundTripDelay", MaximumOutboundRoundTripDelay);
            writer.WriteTimeSpanValue("mediaDuration", MediaDuration);
            writer.WriteLongValue("networkLinkSpeedInBytes", NetworkLinkSpeedInBytes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("outboundPackets", OutboundPackets);
            writer.WriteStringValue("remoteIPAddress", RemoteIPAddress);
            writer.WriteIntValue("remotePort", RemotePort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
