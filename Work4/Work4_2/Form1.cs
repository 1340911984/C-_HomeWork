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
        int Tcik__num = 0;
        int Alarm_num = 0;
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
            Tcik__num++;
            this.message.Text = "控制台信息：" + System.DateTime.Now.ToString("我在 mm分-ss秒 ") + "Tick了第"+ Tcik__num + "下";
        }

        private void Alarm_Click(object sender, EventArgs e)
        {
            Console.WriteLine("闹钟响了");
            Alarm_num++;
            this.message.Text = "控制台信息：" + System.DateTime.Now.ToString("我在 mm分-ss秒") + "Alarm了第" + Alarm_num + "下"; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Time.Text ="时间：" + System.DateTime.Now.ToString("yyyy年-MM月-dd日-HH时-mm分-ss秒");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
