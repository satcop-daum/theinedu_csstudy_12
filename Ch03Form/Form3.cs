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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //3세미만은 무료
            //카드, 국가유공자 => 일반할인(8000)
            //13세미만 ========> 특별할인(4000)
            //17시이후입장 =====> 특별할인(4000)

            int age = Convert.ToInt32(tbAge.Text);//나이
            int time = Convert.ToInt32(cbTime.SelectedItem);//입장시간
            bool cardYn = cbCardYn.Checked;//복지카드여부
            bool mnmYn = cbMnmYn.Checked;//국가유공자여부

            int cost = GetCost(age, time, cardYn, mnmYn);

            tbResult.Text = Convert.ToString(cost);
        }


        //함수(메서드) 추가
        //입장료 계산하는 함수
        //전달되는 파라미터(인자) : 나이, 입장시간, 복지카드여부, 국가유공자여부
        //리턴하는 값: 입장료(정수)
        int GetCost_1(int age, int time, bool cardYn, bool mnmYn)
        {
            int cost = 10000;

            if (age < 3)
            {
                cost = 0;
            }
            else if (time > 17 || age < 13)
            {
                cost = 4000;
            }
            else if (cardYn || mnmYn)
            {
                cost = 8000;
            }

            return cost;
        }

        int GetCost(int age, int time, bool cardYn, bool mnmYn)
        {
            if (age < 3)
            {
                return 0;
            }
            else if (time > 17 || age < 13)
            {
                return 4000;
            }
            else if (cardYn || mnmYn)
            {
                return 8000;
            }

            return 10000;
        }



    }
}
