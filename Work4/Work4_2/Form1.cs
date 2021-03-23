using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work4_2
{
    public partial class Form1 : Form
    {
        DateTime now = DateTime.UtcNow;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Tick_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Time.Text);
            this.message.Text = "控制台信息：" + System.DateTime.Now.ToString("我在 HH时-mm分 Tick了一下");
        }

        private void Alarm_Click(object sender, EventArgs e)
        {
            Console.WriteLine("闹钟响了");
            this.message.Text = "控制台信息：" + System.DateTime.Now.ToString("我在 HH时-mm分 ") + "Alarm了一下";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Time.Text = "时间：" + System.DateTime.Now.ToString("yyyy年-MM月-dd日-HH时-mm分-ss秒");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
