using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDessertShop
{
    public partial class KeyboardForm : Form
    {
        private TextBox tt;

        public KeyboardForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        public void SetTextBoxForOutput(TextBox t)
        {
            tt = t;
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            if (tt == null) return;

            Button b = (Button)sender;
            tt.Text += b.Text;                    
            tt.Focus();
            tt.SelectionStart = tt.Text.Length;   
        }


        private void KeyboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (tt == null || tt.Text.Length == 0) return;

            tt.Text = tt.Text.Substring(0, tt.Text.Length - 1);
            tt.Focus();
            tt.SelectionStart = tt.Text.Length;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
