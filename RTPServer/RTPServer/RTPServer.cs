using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTPServer
{
    public partial class RTPServer : Form
    {
        Capture capture;
        public RTPServer()
        {
            InitializeComponent();
        }

        private void tSBTPlayRTSP_Click(object sender, EventArgs e)
        {
            string RTSPStr = tSTBRTSPStream.Text.Trim();
            capture = new Capture(RTSPStr);
            capture.ImageGrabbed += Capture_ImageGrabbed;
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);
            IBShow.Image = frame;
        }

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

        private void tSBTPlayCamera_Click(object sender, EventArgs e)
        {
            capture = new Capture();
            capture.ImageGrabbed += Capture_ImageGrabbed;
        }

        private void tSBTStart_Click(object sender, EventArgs e)
        {

        }
    }
}
