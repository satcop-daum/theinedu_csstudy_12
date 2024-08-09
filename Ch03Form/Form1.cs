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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼 클릭 이벤트!!!");

            int score = Convert.ToInt32(tbInput.Text);
            String result = "";

            if (score >= 95) {
                result = "A+";
            } else if (score >= 90) {
                result = "A";
            } else if (score >= 85) {
                result = "B+";
            } else if (score >= 80) {
                result = "B";
            } else if (score >= 75) {
                result = "C+";
            } else if (score >= 70) {
                result = "C";    
            } else if (score >= 65) {
                result = "D+";
            } else if (score >= 60) {
                result = "D";
            } else {
                result = "F";
            }

            tbResult.Text = result;





        }
    }
}
