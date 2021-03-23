namespace Work4_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Button();
            this.Alarm = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "⏰";
            // 
            // Tick
            // 
            this.Tick.Location = new System.Drawing.Point(160, 229);
            this.Tick.Name = "Tick";
            this.Tick.Size = new System.Drawing.Size(152, 78);
            this.Tick.TabIndex = 1;
            this.Tick.Text = "嘀嗒";
            this.Tick.UseVisualStyleBackColor = true;
            this.Tick.Click += new System.EventHandler(this.Tick_Click);
            // 
            // Alarm
            // 
            this.Alarm.Location = new System.Drawing.Point(424, 229);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(152, 78);
            this.Alarm.TabIndex = 2;
            this.Alarm.Text = "响铃";
            this.Alarm.UseVisualStyleBackColor = true;
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(216, 162);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(360, 21);
            this.Time.TabIndex = 3;
            this.Time.Text = "时间：";
            this.Time.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(216, 375);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(360, 21);
            this.message.TabIndex = 4;
            this.message.Text = "控制台信息：";
            this.message.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.Tick);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Tick;
        private System.Windows.Forms.Button Alarm;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox message;
    }
}

