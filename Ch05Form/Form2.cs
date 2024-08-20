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


        // filePath에 있는 파일을 읽어서 텍스트 문자열을 리턴하는 메서드
        string getTextFromFile(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);

            string allText = "";
            while (true)
            {
                string readText = streamReader.ReadLine();
                if (readText == null)
                {
                    break;
                }

                allText += "\r\n" + readText;
            }

            return allText;
        }

        // text의 내용을 filePath의 파일에 저장하는 메서드
        void saveFileFromText(string filePath, string text)
        {  
            File.WriteAllText(filePath, text);
        }


        private void btnFileSave_Click(object sender, EventArgs e)
        {
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

            tbMemo.Text = getTextFromFile(ofDialog.FileName);


        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult result = sfDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            saveFileFromText(sfDialog.FileName, tbMemo.Text);

        }
    }
}
