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

            LoadConfig();
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

        private void lblTime_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void cmnTextColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK) 
            {
                return;
            }

            lblTime.ForeColor = colorDialog.Color;

        }

        private void cmnBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            lblTime.BackColor = colorDialog.Color;

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();
        }

        void saveData()
        {
            //텍스트색상(r,g,b): 0-255, 0-255, 0-255
            //배경색상
            //알람체크여부: true/false
            //시간: 0~24
            //분: 0~60

            //텍스트형태 저장=> 문자열
            /*
            
            210|122|98|124|57|49|true|17|30
             
            */

            int foreColorRed = lblTime.ForeColor.R;
            int foreColorGreen = lblTime.ForeColor.G;
            int foreColorBlue = lblTime.ForeColor.B;

            int backColorRed = lblTime.BackColor.R;
            int backColorGreen = lblTime.BackColor.G;
            int backColorBlue = lblTime.BackColor.B;

            bool alarmYn = cbAlarmYn.Checked;

            int hour = (int)nudAlarmHour.Value;
            int minute = (int)nudAlarmMinute.Value;

            string text = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}"
                , foreColorRed
                , foreColorGreen
                , foreColorBlue
                , backColorRed
                , backColorGreen
                , backColorBlue
                , alarmYn
                , hour
                , minute);

            string configFilePath = Application.StartupPath + "\\config.dat";
            
            FileUtils.SaveFileFromText(configFilePath, text);

        }

        private void LoadConfig()
        {
            string configFilePath = Application.StartupPath + "\\config.dat";

            if (!File.Exists(configFilePath))
            {
                return;
            }

            string text = FileUtils.GetTextFromFile(configFilePath);

            string[] arrValue = text.Split('|');
            // ==> 255|255|0|255|0|0|False|11|22

            int foreColorRed = Convert.ToInt32(arrValue[0]);
            int foreColorGreen = Convert.ToInt32(arrValue[1]);
            int foreColorBlue = Convert.ToInt32(arrValue[2]);

            int backColorRed = Convert.ToInt32(arrValue[3]);
            int backColorGreen = Convert.ToInt32(arrValue[4]);
            int backColorBlue = Convert.ToInt32(arrValue[5]);

            bool alarmYn = Convert.ToBoolean(arrValue[6]);

            int hour = Convert.ToInt32(arrValue[7]);
            int minute = Convert.ToInt32(arrValue[8]);


            lblTime.ForeColor = Color.FromArgb(foreColorRed, foreColorGreen, foreColorBlue);
            lblTime.BackColor = Color.FromArgb(backColorRed, backColorGreen, backColorBlue);

            cbAlarmYn.Checked = alarmYn;

            nudAlarmHour.Value = hour;
            nudAlarmMinute.Value = minute;
        }



    }
}










