using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch05Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResizeCotnrols();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            ResizeCotnrols();
        }


        void ResizeCotnrols()
        {
            tbMemo.Location = new Point(10, 30);
            tbMemo.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 40);
        }


        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            tbMemo.Text = "";

        }

        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            tbMemo.Text = FileUtils.GetTextFromFile(ofDialog.FileName);


        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult result = sfDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            FileUtils.SaveFileFromText(sfDialog.FileName, tbMemo.Text);

        }
    }
}
