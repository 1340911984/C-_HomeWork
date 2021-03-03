using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口版本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int b1 = 0;
        int b2 = 0;
        int b3 = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            b1 = int.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            b2 = int.Parse(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b3 = b2 + b1;
            textBox5.Text = b3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b3 = b1 - b2;
            textBox5.Text = b3.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b3 = b2 * b1;
            textBox5.Text = b3.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b3 = b1 / b2;
            textBox5.Text = b3.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            b3 = b2 = b1 = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
