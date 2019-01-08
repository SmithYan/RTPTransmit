using Emgu.CV;
using StreamCoders.Network;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RTPServer
{
    public partial class RTPServer : Form
    {
        Capture capture;
        /// <summary>
        /// RTP工厂
        /// 
        /// </summary>
        RTPFactory rTPFactory;
        /// <summary>
        /// 是否传送
        /// </summary>
        public bool StartToSend { get; set; }
        public RTPServer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 播放RTSP流
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlayRTSP_Click(object sender, EventArgs e)
        {
            string RTSPStr = tSTBRTSPStream.Text.Trim();
            capture = new Capture(RTSPStr);
            capture.ImageGrabbed += Capture_ImageGrabbed;
        }
        /// <summary>
        /// 图片解析事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);
            IBShow.Image = frame;
            if (StartToSend)//如果可以开始传送
            {
                //新建流
                var ms = new MemoryStream();
                //将图片以Jpeg格式保存到流中
                frame.Bitmap.Save(ms, ImageFormat.Jpeg);
                //将流转化为byte数据
                var data = ms.ToArray(); //图片数据
                ms.Close();
                
                //Rtp 协议发送 构建rtp包
                var timeStamp = DateTime.Now.ToUniversalTime().Ticks;
                var packetSize = 1000 - 12;//一个rtp包如果是经过UDP传输的原则上不要超过1460
                //如果有数据持续发送
                while (data.Length > 0)
                {
                    //初始化RTP包开始构建
                    var rtpPacket = new RTPPacket
                    {
                        //SSRC = ,//同步源
                        Timestamp = (int)timeStamp,//时间戳
                        DataPointer = data.Take(packetSize).ToArray(),//帧数据
                        Marker = data.Length <= packetSize
                    };
                    //在RTP工厂中发送此RTP包
                    rTPFactory.Sender.Send(rtpPacket);
                    //返回剩余数据
                    data = data.Skip(packetSize).ToArray();
                }
            }
        }
        /// <summary>
        /// 播放按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlay_Click(object sender, EventArgs e)
        {
            if (tSBTPlay.Text=="Play")
            {
                capture.Start();
                tSBTPlay.Text = "Pause";
            }
            else
            {
                capture.Stop();
                tSBTPlay.Text = "Play";
            }
        }
        /// <summary>
        /// 播放本地文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlayLocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                RestoreDirectory = false
            };
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                capture = new Capture(openFileDialog.FileName);
                capture.ImageGrabbed += Capture_ImageGrabbed;
            }
        }
        /// <summary>
        /// 播放本地摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlayCamera_Click(object sender, EventArgs e)
        {
            capture = new Capture();
            capture.ImageGrabbed += Capture_ImageGrabbed;
        }
        /// <summary>
        /// 开启RTP发送服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTStart_Click(object sender, EventArgs e)
        {
            if (rTPFactory != null)
            {
                StartToSend = !StartToSend; //启动服务
                tSBTStart.Text = StartToSend ? "Stop" : "Start";
            }
            else
            {
                //初始化RTPSession
                var rtpIp = tSTBRtpIP.Text.Trim();
                var rtpPort = Convert.ToInt32(tSTBRtpPort.Text.Trim());
                var rtcpIp = tSTBRtcpIp.Text.Trim();
                var rtcpPort = Convert.ToInt32(tSTBRtcpPort.Text.Trim());
                var forwardIp = tSTBAimIP.Text.Trim();
                var forwardPort = Convert.ToInt32(tSTBAimPort.Text.Trim());

                rTPFactory = new RTPFactory(rtpIp, rtpPort, rtcpIp, rtcpPort, forwardIp, forwardPort); //配置好

                tSTBRtpIP.ReadOnly = true;
                tSTBRtpPort.ReadOnly = true;
                tSTBRtcpIp.ReadOnly = true;
                tSTBRtcpPort.ReadOnly = true;
                tSTBAimIP.ReadOnly = true;
                tSTBAimPort.ReadOnly = true;
                StartToSend = !StartToSend; //启动服务
                tSBTStart.Text = StartToSend ? "Stop" : "Start";
            }
        }
    }
}
