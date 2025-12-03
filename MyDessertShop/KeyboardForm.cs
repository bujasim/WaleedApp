using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyDessertShop
{
    public partial class KeyboardForm : Form
    {
        private TextBox targetTextBox;
        private TableLayoutPanel mainLayout;
        private const int ButtonSize = 70;
        private const int ButtonMargin = 5;

        public KeyboardForm()
        {
            InitializeComponent();
            BuildKeyboard();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.FromArgb(249, 245, 238);
        }

        public void SetTextBoxForOutput(TextBox textBox)
        {
            targetTextBox = textBox;
        }

        private void BuildKeyboard()
        {
            this.Controls.Clear();

            // Keyboard rows
            string[] row1 = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
            string[] row2 = { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            string[] row3 = { "Z", "X", "C", "V", "B", "N", "M" };

            int keyWidth = ButtonSize + ButtonMargin * 2;
            int row1Width = row1.Length * keyWidth;

            mainLayout = new TableLayoutPanel();
            mainLayout.AutoSize = true;
            mainLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 5;
            mainLayout.Padding = new Padding(10);
            mainLayout.Location = new Point(10, 10);

            // Row 1: Q-P
            var panel1 = CreateKeyRow(row1);
            mainLayout.Controls.Add(panel1);

            // Row 2: A-L (slightly indented)
            var panel2 = CreateKeyRow(row2);
            panel2.Padding = new Padding(keyWidth / 2, 0, 0, 0);
            mainLayout.Controls.Add(panel2);

            // Row 3: Z-M (more indented)
            var panel3 = CreateKeyRow(row3);
            panel3.Padding = new Padding(keyWidth, 0, 0, 0);
            mainLayout.Controls.Add(panel3);

            // Row 4: Space bar
            var panel4 = new FlowLayoutPanel();
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.WrapContents = false;
            panel4.Padding = new Padding(keyWidth, 0, 0, 0);

            var spaceBtn = CreateKey("Space", keyWidth * 5);
            spaceBtn.Click += (s, e) => TypeCharacter(" ");
            panel4.Controls.Add(spaceBtn);

            mainLayout.Controls.Add(panel4);

            // Row 5: Backspace and Close
            var panel5 = new FlowLayoutPanel();
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.WrapContents = false;

            var backspaceBtn = CreateKey("⌫ Backspace", keyWidth * 3);
            backspaceBtn.Click += BtnBackspace_Click;
            panel5.Controls.Add(backspaceBtn);

            var closeBtn = CreateKey("Close", keyWidth * 2);
            closeBtn.Click += (s, e) => this.Close();
            closeBtn.BackColor = Color.FromArgb(166, 124, 82);
            closeBtn.ForeColor = Color.White;
            panel5.Controls.Add(closeBtn);

            mainLayout.Controls.Add(panel5);

            this.Controls.Add(mainLayout);
            this.ClientSize = new Size(row1Width + 40, mainLayout.PreferredSize.Height + 20);
        }

        private FlowLayoutPanel CreateKeyRow(string[] keys)
        {
            var panel = new FlowLayoutPanel();
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.WrapContents = false;

            foreach (string key in keys)
            {
                var btn = CreateKey(key, ButtonSize);
                btn.Click += LetterButton_Click;
                panel.Controls.Add(btn);
            }

            return panel;
        }

        private Button CreateKey(string text, int width)
        {
            var btn = new Button();
            btn.Text = text;
            btn.Size = new Size(width, ButtonSize);
            btn.Margin = new Padding(ButtonMargin);
            btn.Font = new Font("Century", 14F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(166, 124, 82);
            btn.BackColor = Color.White;
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            if (targetTextBox == null) return;

            Button btn = (Button)sender;
            TypeCharacter(btn.Text);
        }

        private void TypeCharacter(string character)
        {
            if (targetTextBox == null) return;

            targetTextBox.Text += character;
            targetTextBox.Focus();
            targetTextBox.SelectionStart = targetTextBox.Text.Length;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (targetTextBox == null || targetTextBox.Text.Length == 0) return;

            targetTextBox.Text = targetTextBox.Text.Substring(0, targetTextBox.Text.Length - 1);
            targetTextBox.Focus();
            targetTextBox.SelectionStart = targetTextBox.Text.Length;
        }

        public void PositionNear(Control control)
        {
            if (control == null) return;

            var screenPos = control.PointToScreen(Point.Empty);
            var screen = Screen.FromControl(control);
            var workingArea = screen.WorkingArea;

            // Position below the control
            int x = screenPos.X;
            int y = screenPos.Y + control.Height + 10;

            // Ensure keyboard stays on screen
            if (x + this.Width > workingArea.Right)
                x = workingArea.Right - this.Width;
            if (x < workingArea.Left)
                x = workingArea.Left;

            if (y + this.Height > workingArea.Bottom)
                y = screenPos.Y - this.Height - 10; // Position above instead

            this.Location = new Point(x, y);
        }

        private void KeyboardForm_Load(object sender, EventArgs e)
        {
        }
    }
}
