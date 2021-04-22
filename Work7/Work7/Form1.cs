using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 5;
        double leng = 70;
        System.Drawing.Pen pen = Pens.Blue;
        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            if (n > 13)
            {
                label1.Text = "已经够大了";
                return;
            }
            else if (n < 1)
            {
                label1.Text = "已经够小了";
                return;
            }
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2, true);
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI/ 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        void drawCayleyTree(int n1 , double x0, double y0, double leng, double th, bool clear)
        {
            if (n1 == 0) return;
            if(clear == true) graphics.Clear(this.BackColor);
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n1 - 1, x1, y1, per1 * leng, th + th1, false);
            drawCayleyTree(n1 - 1, x1, y1, per2 * leng, th - th2, false);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            ;
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            label1.Text = "现在递归深度是：" + n;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n--;
            label1.Text = "现在递归深度是：" + n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            leng += 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            leng -= 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            th1++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            th2++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            th1--;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            th2++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Blue;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Green;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Red;
        }
    }
    
}
