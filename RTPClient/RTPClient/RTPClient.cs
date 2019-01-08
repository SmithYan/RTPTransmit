using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StreamCoders.Network;

namespace RTPClient
{
    public partial class RTPClient : Form
    {
        /// <summary>
        /// RTP工厂
        /// </summary>
        RTPFactory rTPFactory;
        /// <summary>
        /// RTP包字典
        /// </summary>
        private Dictionary<uint, List<RTPPacket>> Clients;
        public RTPClient()
        {
            InitializeComponent();
            //初始化字典
            Clients = new Dictionary<uint, List<RTPPacket>>();
        }
        /// <summary>
        /// 连接按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTConnect_Click(object sender, EventArgs e)
        {
            string rtpIp = tSTBRtpIP.Text;
            int rtpPort = Convert.ToInt32(tSTBRtpPort.Text);
            string rtcpIp = tSTBRtcpIp.Text;
            int rtcpPort = Convert.ToInt32(tSTBRtcpPort.Text);
            string forwardIp = tSTBAimIP.Text;
            int forwardPort = Convert.ToInt32(tSTBAimPort.Text);
            //初始化RTP工厂
            rTPFactory = new RTPFactory(rtpIp, rtpPort, rtcpIp, rtcpPort, forwardIp, forwardPort); 
            rTPFactory.Session.NewRTPPacket = NewRTPPacket;
            rTPFactory.Session.NewRTCPPacket = NewRTCPPacket;
        }

        private void NewRTCPPacket(RTCPCompoundPacket packet)
        {
        }
        /// <summary>
        /// 收到RTP包进行处理
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>
        private bool NewRTPPacket(RTPPacket packet)
        {
            //如果接受端第一次接受到某源的数据，则加入到
            if (!Clients.ContainsKey(packet.SSRC))
            {
                if (Clients.Count < 4)//如果发送端为4，则丢弃包
                {
                    Clients.Add(packet.SSRC, new List<RTPPacket> { packet });
                }
            }
            else
            {
                Clients[packet.SSRC].Add(packet);
            }
            if (packet.Marker)//如果已经发送完毕
            {
                //丢包检测
                var orderPackets = Clients[packet.SSRC].OrderBy(rtpPacket => rtpPacket.SequenceNumber);
                if (Clients[packet.SSRC].Count != (orderPackets.Last().SequenceNumber - orderPackets.First().SequenceNumber + 1))
                {
                    //清空缓存区
                    Clients[packet.SSRC].Clear();
                    return true;
                }
                //包重组
                var count = Clients[packet.SSRC].Sum(rtpPacket => rtpPacket.DataSize);
                var newData = new byte[count];
                long offSet = 0;
                foreach (var rtpPacket in Clients[packet.SSRC])
                {
                    Array.Copy(rtpPacket.DataPointer, 0, newData, offSet, rtpPacket.DataSize);
                    offSet += rtpPacket.DataSize;
                }
                Clients[packet.SSRC].Clear();//清空缓存区

                var ms = new MemoryStream(newData);
                try
                {
                    var bmp = new Bitmap(Image.FromStream(ms));
                    PBShow.Image = bmp;
                }
                catch (Exception)
                {

                }
                finally
                {
                    ms.Close();
                }
            }
            return true;
        }
    }
}
