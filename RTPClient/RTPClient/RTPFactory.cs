using StreamCoders.Network;
using System;
using System.Net;

namespace RTPClient
{
    /// <summary>
    /// RTP工厂
    /// </summary>
    class RTPFactory
    {
        /// <summary>
        /// 只读RTP会话端
        /// </summary>
        public readonly RTPSession Session;
        /// <summary>
        /// RTP发送者
        /// </summary>
        public RTPSender Sender;
        /// <summary>
        /// RTP接收者
        /// </summary>
        public RTPReceiver Receiver;
        /// <summary>
        /// RTP参与者
        /// </summary>
        private RTPParticipant participant;
        /// <summary>
        /// RTP发送参与者
        /// </summary>
        private RTPParticipant senderParticipant;

        public RTPFactory(String RTPipAddress, int RTPport, String RTCPipAddress, int RTCPport, String forwardIP, int forwardPort)
        {
            //初始会话端
            Session = new RTPSession();
            //初始化发送者
            Sender = new RTPSender();
            //初始化接收者
            Receiver = new RTPReceiver();

            var senderEp = new IPEndPoint(IPAddress.Parse(forwardIP), forwardPort);
            //将发送参与者初始化绑定到目的端口
            senderParticipant = new RTPParticipant(senderEp);
            //将发送参与者添加到发送者中
            Sender.AddParticipant(senderParticipant);
            //将发送者添加到会话端中
            Session.AddSender(Sender);

            var rtpEp = new IPEndPoint(IPAddress.Parse(RTPipAddress), RTPport);
            var rtcpEp = new IPEndPoint(IPAddress.Parse(RTCPipAddress), RTCPport);
            //将RTP参与者初始化绑定到RTP网络端点以及RTCP网络端点
            participant = new RTPParticipant(rtpEp, rtcpEp);
            //将RTP参与者添加到RTP接收者中
            Receiver.AddParticipant(participant);
            //将RTP接收者添加到会话端中
            Session.AddReceiver(Receiver);
        }
    }
}
