namespace MyDessertShop
{
    partial class NotificationForm
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
            this.MessageLbl = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLbl
            // 
            this.MessageLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageLbl.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLbl.Location = new System.Drawing.Point(0, 0);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(432, 77);
            this.MessageLbl.TabIndex = 0;
            this.MessageLbl.Text = "Message";
            this.MessageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(278, 112);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 49);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // NotificationForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 173);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.MessageLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NotificationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Button btnOk;
    }
}