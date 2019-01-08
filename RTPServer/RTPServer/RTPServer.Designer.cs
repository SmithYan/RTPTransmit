namespace RTPServer
{
    partial class RTPServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTPServer));
            this.TSShow = new System.Windows.Forms.ToolStrip();
            this.tSLRTSPStreamText = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRTSPStream = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPlayRTSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPlayLocal = new System.Windows.Forms.ToolStripButton();
            this.tSBTPlayCamera = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPlay = new System.Windows.Forms.ToolStripButton();
            this.TSSend = new System.Windows.Forms.ToolStrip();
            this.tSLRtpIP = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRtpIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLRtpPort = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRtpPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLRtcpIP = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRtcpIp = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLRtcpPort = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRtcpPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLAimIP = new System.Windows.Forms.ToolStripLabel();
            this.tSTBAimIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLAimPort = new System.Windows.Forms.ToolStripLabel();
            this.tSTBAimPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTStart = new System.Windows.Forms.ToolStripButton();
            this.IBShow = new Emgu.CV.UI.ImageBox();
            this.TSShow.SuspendLayout();
            this.TSSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBShow)).BeginInit();
            this.SuspendLayout();
            // 
            // TSShow
            // 
            this.TSShow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TSShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLRTSPStreamText,
            this.tSTBRTSPStream,
            this.toolStripSeparator4,
            this.tSBTPlayRTSP,
            this.toolStripSeparator5,
            this.tSBTPlayLocal,
            this.tSBTPlayCamera,
            this.toolStripSeparator6,
            this.tSBTPlay});
            this.TSShow.Location = new System.Drawing.Point(0, 0);
            this.TSShow.Name = "TSShow";
            this.TSShow.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TSShow.Size = new System.Drawing.Size(1162, 27);
            this.TSShow.TabIndex = 6;
            this.TSShow.Text = "toolStrip2";
            // 
            // tSLRTSPStreamText
            // 
            this.tSLRTSPStreamText.Name = "tSLRTSPStreamText";
            this.tSLRTSPStreamText.Size = new System.Drawing.Size(130, 24);
            this.tSLRTSPStreamText.Text = "RTSPStreamText";
            // 
            // tSTBRTSPStream
            // 
            this.tSTBRTSPStream.AutoSize = false;
            this.tSTBRTSPStream.Name = "tSTBRTSPStream";
            this.tSTBRTSPStream.Size = new System.Drawing.Size(600, 27);
            this.tSTBRTSPStream.Text = "rtsp://admin:hldz123123@192.168.1.64:554/h264/ch1/main/av_stream";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTPlayRTSP
            // 
            this.tSBTPlayRTSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayRTSP.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayRTSP.Image")));
            this.tSBTPlayRTSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayRTSP.Name = "tSBTPlayRTSP";
            this.tSBTPlayRTSP.Size = new System.Drawing.Size(50, 24);
            this.tSBTPlayRTSP.Text = "RTSP";
            this.tSBTPlayRTSP.Click += new System.EventHandler(this.tSBTPlayRTSP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTPlayLocal
            // 
            this.tSBTPlayLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayLocal.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayLocal.Image")));
            this.tSBTPlayLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayLocal.Name = "tSBTPlayLocal";
            this.tSBTPlayLocal.Size = new System.Drawing.Size(51, 24);
            this.tSBTPlayLocal.Text = "Local";
            this.tSBTPlayLocal.Click += new System.EventHandler(this.tSBTPlayLocal_Click);
            // 
            // tSBTPlayCamera
            // 
            this.tSBTPlayCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayCamera.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayCamera.Image")));
            this.tSBTPlayCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayCamera.Name = "tSBTPlayCamera";
            this.tSBTPlayCamera.Size = new System.Drawing.Size(68, 24);
            this.tSBTPlayCamera.Text = "Camera";
            this.tSBTPlayCamera.Click += new System.EventHandler(this.tSBTPlayCamera_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTPlay
            // 
            this.tSBTPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlay.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlay.Image")));
            this.tSBTPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlay.Name = "tSBTPlay";
            this.tSBTPlay.Size = new System.Drawing.Size(42, 24);
            this.tSBTPlay.Text = "Play";
            this.tSBTPlay.Click += new System.EventHandler(this.tSBTPlay_Click);
            // 
            // TSSend
            // 
            this.TSSend.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TSSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLRtpIP,
            this.tSTBRtpIP,
            this.toolStripSeparator1,
            this.tSLRtpPort,
            this.tSTBRtpPort,
            this.toolStripSeparator2,
            this.tSLRtcpIP,
            this.tSTBRtcpIp,
            this.toolStripSeparator7,
            this.tSLRtcpPort,
            this.tSTBRtcpPort,
            this.toolStripSeparator3,
            this.tSLAimIP,
            this.tSTBAimIP,
            this.toolStripSeparator9,
            this.tSLAimPort,
            this.tSTBAimPort,
            this.toolStripSeparator8,
            this.tSBTStart});
            this.TSSend.Location = new System.Drawing.Point(0, 27);
            this.TSSend.Name = "TSSend";
            this.TSSend.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TSSend.Size = new System.Drawing.Size(1162, 27);
            this.TSSend.TabIndex = 8;
            this.TSSend.Text = "toolStrip1";
            // 
            // tSLRtpIP
            // 
            this.tSLRtpIP.Name = "tSLRtpIP";
            this.tSLRtpIP.Size = new System.Drawing.Size(50, 24);
            this.tSLRtpIP.Text = "RTPIP";
            // 
            // tSTBRtpIP
            // 
            this.tSTBRtpIP.Name = "tSTBRtpIP";
            this.tSTBRtpIP.Size = new System.Drawing.Size(100, 27);
            this.tSTBRtpIP.Text = "127.0.0.1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tSLRtpPort
            // 
            this.tSLRtpPort.Name = "tSLRtpPort";
            this.tSLRtpPort.Size = new System.Drawing.Size(77, 24);
            this.tSLRtpPort.Text = "RTPPORT";
            // 
            // tSTBRtpPort
            // 
            this.tSTBRtpPort.Name = "tSTBRtpPort";
            this.tSTBRtpPort.Size = new System.Drawing.Size(100, 27);
            this.tSTBRtpPort.Text = "20000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tSLRtcpIP
            // 
            this.tSLRtcpIP.Name = "tSLRtcpIP";
            this.tSLRtcpIP.Size = new System.Drawing.Size(60, 24);
            this.tSLRtcpIP.Text = "RTCPIP";
            // 
            // tSTBRtcpIp
            // 
            this.tSTBRtcpIp.Name = "tSTBRtcpIp";
            this.tSTBRtcpIp.Size = new System.Drawing.Size(100, 27);
            this.tSTBRtcpIp.Text = "127.0.0.1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // tSLRtcpPort
            // 
            this.tSLRtcpPort.Name = "tSLRtcpPort";
            this.tSLRtcpPort.Size = new System.Drawing.Size(87, 24);
            this.tSLRtcpPort.Text = "RTCPPORT";
            // 
            // tSTBRtcpPort
            // 
            this.tSTBRtcpPort.Name = "tSTBRtcpPort";
            this.tSTBRtcpPort.Size = new System.Drawing.Size(100, 27);
            this.tSTBRtcpPort.Text = "3565";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tSLAimIP
            // 
            this.tSLAimIP.Name = "tSLAimIP";
            this.tSLAimIP.Size = new System.Drawing.Size(56, 24);
            this.tSLAimIP.Text = "AIMIIP";
            // 
            // tSTBAimIP
            // 
            this.tSTBAimIP.Name = "tSTBAimIP";
            this.tSTBAimIP.Size = new System.Drawing.Size(100, 27);
            this.tSTBAimIP.Text = "127.0.0.1";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // tSLAimPort
            // 
            this.tSLAimPort.Name = "tSLAimPort";
            this.tSLAimPort.Size = new System.Drawing.Size(79, 24);
            this.tSLAimPort.Text = "AIMPORT";
            // 
            // tSTBAimPort
            // 
            this.tSTBAimPort.Name = "tSTBAimPort";
            this.tSTBAimPort.Size = new System.Drawing.Size(100, 27);
            this.tSTBAimPort.Text = "10000";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTStart
            // 
            this.tSBTStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTStart.Image = ((System.Drawing.Image)(resources.GetObject("tSBTStart.Image")));
            this.tSBTStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTStart.Name = "tSBTStart";
            this.tSBTStart.Size = new System.Drawing.Size(48, 24);
            this.tSBTStart.Text = "Start";
            this.tSBTStart.Click += new System.EventHandler(this.tSBTStart_Click);
            // 
            // IBShow
            // 
            this.IBShow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.IBShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IBShow.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.IBShow.Location = new System.Drawing.Point(0, 54);
            this.IBShow.Name = "IBShow";
            this.IBShow.Size = new System.Drawing.Size(1162, 533);
            this.IBShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IBShow.TabIndex = 9;
            this.IBShow.TabStop = false;
            // 
            // RTPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 587);
            this.Controls.Add(this.IBShow);
            this.Controls.Add(this.TSSend);
            this.Controls.Add(this.TSShow);
            this.Name = "RTPServer";
            this.Text = "RTPServer";
            this.TSShow.ResumeLayout(false);
            this.TSShow.PerformLayout();
            this.TSSend.ResumeLayout(false);
            this.TSSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSShow;
        private System.Windows.Forms.ToolStripLabel tSLRTSPStreamText;
        private System.Windows.Forms.ToolStripTextBox tSTBRTSPStream;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tSBTPlayRTSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tSBTPlayLocal;
        private System.Windows.Forms.ToolStripButton tSBTPlayCamera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tSBTPlay;
        private System.Windows.Forms.ToolStrip TSSend;
        private System.Windows.Forms.ToolStripLabel tSLRtpIP;
        private System.Windows.Forms.ToolStripTextBox tSTBRtpIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tSLRtpPort;
        private System.Windows.Forms.ToolStripTextBox tSTBRtpPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tSLRtcpIP;
        private System.Windows.Forms.ToolStripTextBox tSTBRtcpIp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel tSLRtcpPort;
        private System.Windows.Forms.ToolStripTextBox tSTBRtcpPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tSLAimIP;
        private System.Windows.Forms.ToolStripTextBox tSTBAimIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel tSLAimPort;
        private System.Windows.Forms.ToolStripTextBox tSTBAimPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tSBTStart;
        private Emgu.CV.UI.ImageBox IBShow;
    }
}