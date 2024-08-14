using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            string inputString = tbInput.Text;
            string checkString = tbOutput.Text;

            bool result = inputString.StartsWith(checkString);

            tbResult.Text = result.ToString();
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            bool result = tbInput.Text.EndsWith(tbOutput.Text);
            tbResult.Text = result.ToString();


        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool result = tbInput.Text.Contains(tbOutput.Text);
            tbResult.Text = result.ToString();

        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            tbOutput.Text = tbInput.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            tbOutput.Text = tbInput.Text.ToLower();
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            tbOutput.Text = tbInput.Text.Substring(4, 6);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string[] texts = tbInput.Text.Split(',');

            string str = "";
            for(int i = 0; i < texts.Length; i++)
            {
                str += texts[i] + "\r\n";
            }
            tbResult.Text = str;

        }
    }
}
