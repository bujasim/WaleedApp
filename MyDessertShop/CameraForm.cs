using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace MyDessertShop
{
    public partial class CameraForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public string ScannedCode { get; private set; }
        public bool IsStaffScan { get; set; } = false;

        public CameraForm()
        {
            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
               ShowBigMessage("No camera found.");
                btnStartScanLc.Enabled = false; 
                return;
            }


            foreach (FilterInfo device in videoDevices)
            {
                cboCamera.Items.Add(device.Name);

            }

            cboCamera.SelectedIndex = 0;
        }


        private void StopCamera()
        {
            if (videoSource != null)
            {
                if (videoSource.IsRunning)
                {
                    videoSource.Stop();
                }

                videoSource = null;
            }
        }

        private void VideoPreview(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pbLoyaltyScan.Image = frame;  
        }

        private void btnStartScanLc_Click(object sender, EventArgs e)
        {
            if (videoDevices == null || videoDevices.Count == 0)
            {
               ShowBigMessage("No camera available.");
                return;
            }

            StopCamera();

            videoSource = new VideoCaptureDevice(videoDevices[cboCamera.SelectedIndex].MonikerString);

            videoSource.NewFrame += VideoPreview;
            videoSource.Start();
            timerLc.Start();

        }

        private void timerLc_Tick(object sender, EventArgs e)
        {
            if (pbLoyaltyScan == null) 
                return;

            var reader = new BarcodeReader();

            try
            {
                var result = reader.Decode((Bitmap)pbLoyaltyScan.Image);

                if (result == null)
                    return;
                

                    timerLc.Stop();
                    ScannedCode = result.Text;

                   ShowBigMessage("Scanned successful.");

                    this.DialogResult = DialogResult.OK;
                    Close();
                

            }
            catch { }

        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerLc.Stop();
            StopCamera();
        }

        private void btnCancelScanLc_Click(object sender, EventArgs e)
        {
            timerLc.Stop();
            StopCamera();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowBigMessage(string message)
        {
            using (var popup = new NotificationForm(message))
            {
                popup.ShowDialog(this);
            }
        }
    }
}
