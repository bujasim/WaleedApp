namespace MyDessertShop
{
    partial class CameraForm
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
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pbLoyaltyScan = new System.Windows.Forms.PictureBox();
            this.btnStartScanLc = new System.Windows.Forms.Button();
            this.timerLc = new System.Windows.Forms.Timer(this.components);
            this.btnCancelScanLc = new System.Windows.Forms.Button();
            this.lblScantitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoyaltyScan)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(1419, 28);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(460, 54);
            this.cboCamera.TabIndex = 0;
            // 
            // pbLoyaltyScan
            // 
            this.pbLoyaltyScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLoyaltyScan.Location = new System.Drawing.Point(420, 156);
            this.pbLoyaltyScan.Name = "pbLoyaltyScan";
            this.pbLoyaltyScan.Size = new System.Drawing.Size(1012, 596);
            this.pbLoyaltyScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoyaltyScan.TabIndex = 1;
            this.pbLoyaltyScan.TabStop = false;
            // 
            // btnStartScanLc
            // 
            this.btnStartScanLc.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScanLc.Location = new System.Drawing.Point(367, 787);
            this.btnStartScanLc.Name = "btnStartScanLc";
            this.btnStartScanLc.Size = new System.Drawing.Size(351, 89);
            this.btnStartScanLc.TabIndex = 2;
            this.btnStartScanLc.Text = "Start";
            this.btnStartScanLc.UseVisualStyleBackColor = true;
            this.btnStartScanLc.Click += new System.EventHandler(this.btnStartScanLc_Click);
            // 
            // timerLc
            // 
            this.timerLc.Tick += new System.EventHandler(this.timerLc_Tick);
            // 
            // btnCancelScanLc
            // 
            this.btnCancelScanLc.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelScanLc.Location = new System.Drawing.Point(1095, 787);
            this.btnCancelScanLc.Name = "btnCancelScanLc";
            this.btnCancelScanLc.Size = new System.Drawing.Size(382, 105);
            this.btnCancelScanLc.TabIndex = 3;
            this.btnCancelScanLc.Text = "Cancel";
            this.btnCancelScanLc.UseVisualStyleBackColor = true;
            this.btnCancelScanLc.Click += new System.EventHandler(this.btnCancelScanLc_Click);
            // 
            // lblScantitle
            // 
            this.lblScantitle.AutoSize = true;
            this.lblScantitle.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScantitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblScantitle.Location = new System.Drawing.Point(31, 53);
            this.lblScantitle.Name = "lblScantitle";
            this.lblScantitle.Size = new System.Drawing.Size(366, 71);
            this.lblScantitle.TabIndex = 4;
            this.lblScantitle.Text = "QR scanner";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(18, 203);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(396, 508);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Hold the QR code steady against the camera/scanner until the system validates the" +
    " code";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblScantitle);
            this.Controls.Add(this.btnCancelScanLc);
            this.Controls.Add(this.btnStartScanLc);
            this.Controls.Add(this.pbLoyaltyScan);
            this.Controls.Add(this.cboCamera);
            this.MaximizeBox = false;
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraForm_FormClosing);
            this.Load += new System.EventHandler(this.CameraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoyaltyScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pbLoyaltyScan;
        private System.Windows.Forms.Button btnStartScanLc;
        private System.Windows.Forms.Timer timerLc;
        private System.Windows.Forms.Button btnCancelScanLc;
        private System.Windows.Forms.Label lblScantitle;
        private System.Windows.Forms.Label lblInstructions;
    }
}