using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch03Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(tbBirthYear.Text) % 12;
            ShowImage(value);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(tbBirthYear.Text) - 1;
            tbBirthYear.Text = value.ToString();
            ShowImage(value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(tbBirthYear.Text) + 1;
            tbBirthYear.Text = value.ToString();
            ShowImage(value);
        }
        
        //숫자값을 던지면(매개변수로 전달) 그에 해당하는 이미지를 보여주는 함수
        void ShowImage(int value)
        {



            string filename = GetFilename(value);
            pbImage.Image = Image.FromFile(filename);
        }

        //숫자값을 매개변수로 전달하면, 띠에 해당하는 이미지 경로를 리턴하는 함수
        string GetFilename(int value)
        {
            string basePath = "C:\\Users\\PARK\\source\\repos\\satcop-daum\\theinedu_csstudy_12\\Ch03Form\\res\\image\\";
            string filename = "";

            //2024 -> 8(용) : 05

            switch (value % 12)
            {
                case 4: filename = "01-쥐.png"; break;
                case 5: filename = "02-소.png"; break;
                case 6: filename = "03-호랑이.png"; break;
                case 7: filename = "04-토끼.png"; break;
                case 8: filename = "05-용.png"; break;
                case 9: filename = "06-뱀.png"; break;
                case 10: filename = "07-말.png"; break;
                case 11: filename = "08-양.png"; break;
                case 0: filename = "09-원숭이.png"; break;
                case 1: filename = "10-닭.png"; break;
                case 2: filename = "11-개.png"; break;
                case 3: filename = "12-돼지.png"; break;
            }

            return basePath + filename;
        }



    }
}
