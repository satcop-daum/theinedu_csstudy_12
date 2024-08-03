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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("안녕하세요!!!");

            int input1 = Convert.ToInt32(tbInput1.Text);
            int input2 = Convert.ToInt32(tbInput2.Text);

            tbResult.Text = Convert.ToString(input1 + input2);


        }
    }
}
