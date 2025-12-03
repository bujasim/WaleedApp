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

        // Design dimensions for scaling
        private const int DesignWidth = 1902;
        private const int DesignHeight = 1033;
        private Panel contentContainer;

        public string ScannedCode { get; private set; }

        public CameraForm()
        {
            InitializeComponent();
        }

        private void ApplyScaling()
        {
            var screenBounds = Screen.PrimaryScreen.Bounds;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = screenBounds;
            this.BackColor = Color.Black;

            contentContainer = new Panel();
            contentContainer.Size = new Size(DesignWidth, DesignHeight);
            contentContainer.BackColor = Color.FromArgb(249, 245, 238);

            var controlsToMove = new List<Control>();
            foreach (Control c in this.Controls)
                controlsToMove.Add(c);
            foreach (Control c in controlsToMove)
            {
                this.Controls.Remove(c);
                contentContainer.Controls.Add(c);
            }

            this.Controls.Add(contentContainer);

            float scaleX = (float)screenBounds.Width / DesignWidth;
            float scaleY = (float)screenBounds.Height / DesignHeight;
            float uniformScale = Math.Min(scaleX, scaleY);

            contentContainer.Scale(new SizeF(uniformScale, uniformScale));

            int scaledWidth = (int)(DesignWidth * uniformScale);
            int scaledHeight = (int)(DesignHeight * uniformScale);
            contentContainer.Location = new Point(
                (screenBounds.Width - scaledWidth) / 2,
                (screenBounds.Height - scaledHeight) / 2
            );
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            ApplyScaling();

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
            if (pbLoyaltyScan?.Image == null)
                return;

            try
            {
                var reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)pbLoyaltyScan.Image);

                if (result == null)
                    return;

                timerLc.Stop();
                ScannedCode = result.Text;

                ShowBigMessage("Scanned successfully!");

                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // Log error but continue scanning - image may not be ready yet
                System.Diagnostics.Debug.WriteLine($"Scan error: {ex.Message}");
            }
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
