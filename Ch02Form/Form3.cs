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
    public partial class Form3 : Form
    {

        int x1 = 0;
        int y1 = 0;

        int x2 = 0;
        int y2 = 0;


        int clickCount = 0;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("마우스 다운!!!!");

            //x1 = e.X;
            //y1 = e.Y;


        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {

            

            //MessageBox.Show("마우스 업!!!!");

            //int x2 = e.X;
            //int y2 = e.Y;



            //Graphics g = CreateGraphics();
            //Pen myPen = new Pen(Color.Blue, 10);
            //g.DrawLine(myPen, x1, y1, x2, y2);


            int x = e.X;
            int y = e.Y;


            if (clickCount % 2 == 0)
            {
                x1 = x;
                y1 = y;
            } else if (clickCount % 2 == 1)
            {
                x2 = x;
                y2 = y;

                Graphics g = CreateGraphics();
                Pen myPen = new Pen(Color.Blue, 10);
                g.DrawLine(myPen, x1, y1, x2, y2);
            }




            clickCount++;


        }

        private void Form3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
