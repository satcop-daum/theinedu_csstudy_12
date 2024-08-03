using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch02Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;

            int value = Convert.ToInt32(input);
            //value = 127549;

            //개수파악
            int cnt50000 = value / 50000;
            int cnt10000 = (value - cnt50000 * 50000) / 10000;
            int cnt5000  = (value - cnt50000 * 50000 - cnt10000 * 10000) / 5000;
            int cnt1000  = (value - cnt50000 * 50000 - cnt10000 * 10000 - cnt5000 * 5000) / 1000;
            int tip      = (value - cnt50000 * 50000 - cnt10000 * 10000 - cnt5000 * 5000) % 1000;


            tb50000.Text = Convert.ToString(cnt50000);
            tb10000.Text = Convert.ToString(cnt10000);
            tb5000.Text = Convert.ToString(cnt5000);
            tb1000.Text = Convert.ToString(cnt1000);
            tbTip.Text = Convert.ToString(tip);

        }
    }
}
