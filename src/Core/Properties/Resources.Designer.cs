﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hermes.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hermes.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bit position must be between 0 and 7.
        /// </summary>
        internal static string ByteExtensions_InvalidBitPosition {
            get {
                return ResourceManager.GetString("ByteExtensions_InvalidBitPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Byte index must be from 1 to 8, starting from msb.
        /// </summary>
        internal static string ByteExtensions_InvalidByteIndex {
            get {
                return ResourceManager.GetString("ByteExtensions_InvalidByteIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bits 7-1 from Acknowledge flags are reserved and must be set to 0.
        /// </summary>
        internal static string ConnectAckFormatter_InvalidAckFlags {
            get {
                return ResourceManager.GetString("ConnectAckFormatter_InvalidAckFlags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session Present flag must be set to 0 for non-zero return codes.
        /// </summary>
        internal static string ConnectAckFormatter_InvalidSessionPresentForErrorReturnCode {
            get {
                return ResourceManager.GetString("ConnectAckFormatter_InvalidSessionPresentForErrorReturnCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client Id cannot exceed 23 bytes.
        /// </summary>
        internal static string ConnectFormatter_ClientIdMaxLengthExceeded {
            get {
                return ResourceManager.GetString("ConnectFormatter_ClientIdMaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client Id value is cannot be null or empty.
        /// </summary>
        internal static string ConnectFormatter_ClientIdRequired {
            get {
                return ResourceManager.GetString("ConnectFormatter_ClientIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is an invalid ClientId. It must contain only numbers and letters.
        /// </summary>
        internal static string ConnectFormatter_InvalidClientIdFormat {
            get {
                return ResourceManager.GetString("ConnectFormatter_InvalidClientIdFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password Flag must be set to 0 if the User Name Flag is set to 0.
        /// </summary>
        internal static string ConnectFormatter_InvalidPasswordFlag {
            get {
                return ResourceManager.GetString("ConnectFormatter_InvalidPasswordFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid protocol name.
        /// </summary>
        internal static string ConnectFormatter_InvalidProtocolName {
            get {
                return ResourceManager.GetString("ConnectFormatter_InvalidProtocolName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved Flag must be always set to 0.
        /// </summary>
        internal static string ConnectFormatter_InvalidReservedFlag {
            get {
                return ResourceManager.GetString("ConnectFormatter_InvalidReservedFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Will Retain Flag must be set to 0 if the Will Flag is set to 0.
        /// </summary>
        internal static string ConnectFormatter_InvalidWillRetainFlag {
            get {
                return ResourceManager.GetString("ConnectFormatter_InvalidWillRetainFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password value must be null or empty if User value is null or empty.
        /// </summary>
        internal static string ConnectFormatter_PasswordNotAllowed {
            get {
                return ResourceManager.GetString("ConnectFormatter_PasswordNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol Level {0} is not supported by the server.
        /// </summary>
        internal static string ConnectFormatter_UnsupportedLevel {
            get {
                return ResourceManager.GetString("ConnectFormatter_UnsupportedLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Header Flag {0} is invalid for {1} packet. Expected value: {2}.
        /// </summary>
        internal static string Formatter_InvalidHeaderFlag {
            get {
                return ResourceManager.GetString("Formatter_InvalidHeaderFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The packet sent cannot be handled by {0}.
        /// </summary>
        internal static string Formatter_InvalidPacket {
            get {
                return ResourceManager.GetString("Formatter_InvalidPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Qos value must be from 0x00 to 0x02.
        /// </summary>
        internal static string Formatter_InvalidQualityOfService {
            get {
                return ResourceManager.GetString("Formatter_InvalidQualityOfService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The received packet cannot be handled by any of the registered formatters.
        /// </summary>
        internal static string PacketManager_PacketUnknown {
            get {
                return ResourceManager.GetString("PacketManager_PacketUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer values are expected to be of two bytes length. The max value supported is 65536.
        /// </summary>
        internal static string ProtocolEncoding_IntegerMaxValueExceeded {
            get {
                return ResourceManager.GetString("ProtocolEncoding_IntegerMaxValueExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Malformed Remaining Length.
        /// </summary>
        internal static string ProtocolEncoding_MalformedRemainingLength {
            get {
                return ResourceManager.GetString("ProtocolEncoding_MalformedRemainingLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String value cannot exceed 65536 bytes of length.
        /// </summary>
        internal static string ProtocolEncoding_StringMaxLengthExceeded {
            get {
                return ResourceManager.GetString("ProtocolEncoding_StringMaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The packet type {0} cannot be handled by this flow provider.
        /// </summary>
        internal static string ProtocolFlowProvider_InvalidPacketType {
            get {
                return ResourceManager.GetString("ProtocolFlowProvider_InvalidPacketType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to get a Flow Type based on Packet Type {0}.
        /// </summary>
        internal static string ProtocolFlowProvider_UnknownPacketType {
            get {
                return ResourceManager.GetString("ProtocolFlowProvider_UnknownPacketType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The QoS publish flow was not completed within the maximum configured message retries of {0}. The connection will be closed.
        /// </summary>
        internal static string PublishFlow_AckMonitor_ExceededMaximumAckRetries {
            get {
                return ResourceManager.GetString("PublishFlow_AckMonitor_ExceededMaximumAckRetries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicated flag must be set to 0 if the QoS is 0.
        /// </summary>
        internal static string PublishFormatter_InvalidDuplicatedWithQoSZero {
            get {
                return ResourceManager.GetString("PublishFormatter_InvalidDuplicatedWithQoSZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet Id is not allowed for packets with QoS 0.
        /// </summary>
        internal static string PublishFormatter_InvalidPacketId {
            get {
                return ResourceManager.GetString("PublishFormatter_InvalidPacketId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Topic name {0} is invalid. It cannot be null or empty and It must not contain wildcard characters .
        /// </summary>
        internal static string PublishFormatter_InvalidTopicName {
            get {
                return ResourceManager.GetString("PublishFormatter_InvalidTopicName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet Id value cannot be null or empty for packets with QoS 1 or 2.
        /// </summary>
        internal static string PublishFormatter_PacketIdRequired {
            get {
                return ResourceManager.GetString("PublishFormatter_PacketIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet Id value is not allowed for QoS 0.
        /// </summary>
        internal static string PublishReceiverFlow_PacketIdNotAllowed {
            get {
                return ResourceManager.GetString("PublishReceiverFlow_PacketIdNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet Id value is required for QoS major than 0.
        /// </summary>
        internal static string PublishReceiverFlow_PacketIdRequired {
            get {
                return ResourceManager.GetString("PublishReceiverFlow_PacketIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No session has been found for client {0}.
        /// </summary>
        internal static string SessionRepository_ClientSessionNotFound {
            get {
                return ResourceManager.GetString("SessionRepository_ClientSessionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Return codes can only be valid QoS values or a failure code (0x80).
        /// </summary>
        internal static string SubscribeAckFormatter_InvalidReturnCodes {
            get {
                return ResourceManager.GetString("SubscribeAckFormatter_InvalidReturnCodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A subscribe acknowledge packet must contain at least one return code.
        /// </summary>
        internal static string SubscribeAckFormatter_MissingReturnCodes {
            get {
                return ResourceManager.GetString("SubscribeAckFormatter_MissingReturnCodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Topic filter {0} is invalid. See protocol specification for more details on Topic Filter rules: http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/os/mqtt-v3.1.1-os.html#_Toc398718106.
        /// </summary>
        internal static string SubscribeFormatter_InvalidTopicFilter {
            get {
                return ResourceManager.GetString("SubscribeFormatter_InvalidTopicFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A subscribe packet must contain at least one Topic Filter / QoS pair.
        /// </summary>
        internal static string SubscribeFormatter_MissingTopicFilterQosPair {
            get {
                return ResourceManager.GetString("SubscribeFormatter_MissingTopicFilterQosPair", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The topic filter {0} is invalid according to the protocol rules and configuration.
        /// </summary>
        internal static string TopicEvaluator_InvalidTopicFilter {
            get {
                return ResourceManager.GetString("TopicEvaluator_InvalidTopicFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The topic name {0} is invalid according to the protocol rules.
        /// </summary>
        internal static string TopicEvaluator_InvalidTopicName {
            get {
                return ResourceManager.GetString("TopicEvaluator_InvalidTopicName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disposing {0}.
        /// </summary>
        internal static string Tracer_Disposing {
            get {
                return ResourceManager.GetString("Tracer_Disposing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ack for message {0} has not been received. Re sending message for client {1}.
        /// </summary>
        internal static string Tracer_PublishFlow_RetryingQoSFlow {
            get {
                return ResourceManager.GetString("Tracer_PublishFlow_RetryingQoSFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unsubscribe packet must contain at least one topic to unsubscribe.
        /// </summary>
        internal static string UnsubscribeFormatter_MissingTopics {
            get {
                return ResourceManager.GetString("UnsubscribeFormatter_MissingTopics", resourceCulture);
            }
        }
    }
}
