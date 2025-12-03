using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyDessertShop
{
    public partial class NotificationForm : Form
    {
        public NotificationForm(string message)
        {
            InitializeComponent();
            BuildLayout(message);
        }

        private void BuildLayout(string message)
        {
            this.Controls.Clear();
            this.BackColor = Color.FromArgb(249, 245, 238);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Notification";

            // Create message label
            var messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Font = new Font("Century", 16F, FontStyle.Bold);
            messageLabel.ForeColor = Color.FromArgb(44, 38, 32);
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.AutoSize = false;
            messageLabel.Dock = DockStyle.Top;
            messageLabel.Height = 100;
            messageLabel.Padding = new Padding(20);

            // Create OK button
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Century", 14F, FontStyle.Bold);
            okButton.Size = new Size(150, 50);
            okButton.DialogResult = DialogResult.OK;
            okButton.BackColor = Color.FromArgb(166, 124, 82);
            okButton.ForeColor = Color.White;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Cursor = Cursors.Hand;

            // Create button panel for centering
            var buttonPanel = new Panel();
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Height = 80;
            buttonPanel.Padding = new Padding(0, 10, 0, 20);

            // Center the button
            okButton.Left = (this.ClientSize.Width - okButton.Width) / 2;
            okButton.Top = 10;
            buttonPanel.Controls.Add(okButton);

            // Handle resize to keep button centered
            buttonPanel.Resize += (s, e) =>
            {
                okButton.Left = (buttonPanel.Width - okButton.Width) / 2;
            };

            this.Controls.Add(buttonPanel);
            this.Controls.Add(messageLabel);

            this.AcceptButton = okButton;
            this.ClientSize = new Size(500, 180);

            // Re-center button after size is set
            okButton.Left = (buttonPanel.Width - okButton.Width) / 2;
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
        }
    }
}
