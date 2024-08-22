using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch06Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine("DateChanged 이벤트 발생");

            Console.WriteLine("Start: " + e.Start);
            Console.WriteLine("End: " + e.End);

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine("DateSelected 이벤트 발생");

            Console.WriteLine("Start: " + e.Start);
            Console.WriteLine("End: " + e.End);

            string dateString = e.Start.ToString("yyyyMMdd") + ".txt";

            Console.WriteLine(dateString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("운동하기");
            checkedListBox1.Items.Add("공부하기");
            checkedListBox1.Items.Add("독서하기", true);
        }
    }
}
