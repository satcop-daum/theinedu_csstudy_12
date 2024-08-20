using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch05Form
{
    public partial class frmMain : Form
    {
        int value1 = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼 클릭!!!!");

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            //ResizeCotnrols();

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            //ResizeCotnrols();
        }

        void ResizeCotnrols()
        {
            //(폼의Width - 버튼의Width) / 2 => 버튼의 x좌표
            //(폼의Height - 버튼의Height) / 2 => 버튼의 y좌표

            int buttonWidth = ClientSize.Width * 80 / 100;
            int buttonHeight = ClientSize.Height * 80 / 100;
            btnOK.Size = new Size(buttonWidth, buttonHeight);

            int x = (ClientSize.Width - btnOK.Width) / 2;
            int y = (ClientSize.Height - btnOK.Height) / 2;
            btnOK.Location = new Point(x, y);
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String time = "";

            if (now.Millisecond < 500)
            {
                time = now.ToString("HH:mm:ss");
            }
            else
            {
                time = now.ToString("HH:mm ss");
            }

            if (now.Hour < 12)
            {
                time = "AM " + time;
            } else
            {
                time = "PM " + time;
            }

            lblTime.Text = time;


            //알람확인
            if (cbAlarmYn.Checked)
            {

                //현재시간 알람을 설정한 시간의 차이 => 1분미만일때 체크
                int gap = (int)(nudAlarmHour.Value * 60 + nudAlarmMinute.Value) - (now.Hour * 60 + now.Minute);
                
                if (gap <= 1)
                {
                    if (now.Millisecond < 500)
                    {
                        lblTime.BackColor = Color.Red;
                    }
                    else
                    {
                        lblTime.BackColor = Color.Black;
                    }

                }



                if (now.Hour == nudAlarmHour.Value 
                    && now.Minute == nudAlarmMinute.Value)
                {
                    cbAlarmYn.Checked = false;
                    MessageBox.Show("알람시간이되었습니다.");
                }

            }

        }

        private void nudAlarmMinute_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
