namespace HomeWork8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clientlabel = new System.Windows.Forms.Label();
            this.OrderIDlabel = new System.Windows.Forms.Label();
            this.OrderIDtextBox1 = new System.Windows.Forms.TextBox();
            this.AddOrderDetailbutton1 = new System.Windows.Forms.Button();
            this.ModifyOrderDetbutton1 = new System.Windows.Forms.Button();
            this.goodslabel = new System.Windows.Forms.Label();
            this.goodstextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientIDBox2 = new System.Windows.Forms.TextBox();
            this.clientnametextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clientlabel
            // 
            this.Clientlabel.AutoSize = true;
            this.Clientlabel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clientlabel.Location = new System.Drawing.Point(113, 257);
            this.Clientlabel.Name = "Clientlabel";
            this.Clientlabel.Size = new System.Drawing.Size(91, 37);
            this.Clientlabel.TabIndex = 26;
            this.Clientlabel.Text = "客户";
            // 
            // OrderIDlabel
            // 
            this.OrderIDlabel.AutoSize = true;
            this.OrderIDlabel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderIDlabel.Location = new System.Drawing.Point(91, 84);
            this.OrderIDlabel.Name = "OrderIDlabel";
            this.OrderIDlabel.Size = new System.Drawing.Size(128, 37);
            this.OrderIDlabel.TabIndex = 25;
            this.OrderIDlabel.Text = "订单号";
            // 
            // OrderIDtextBox1
            // 
            this.OrderIDtextBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderIDtextBox1.Location = new System.Drawing.Point(225, 81);
            this.OrderIDtextBox1.Name = "OrderIDtextBox1";
            this.OrderIDtextBox1.Size = new System.Drawing.Size(392, 50);
            this.OrderIDtextBox1.TabIndex = 24;
            this.OrderIDtextBox1.TextChanged += new System.EventHandler(this.OrderIDtextBox1_TextChanged);
            // 
            // AddOrderDetailbutton1
            // 
            this.AddOrderDetailbutton1.Location = new System.Drawing.Point(855, 795);
            this.AddOrderDetailbutton1.Name = "AddOrderDetailbutton1";
            this.AddOrderDetailbutton1.Size = new System.Drawing.Size(217, 73);
            this.AddOrderDetailbutton1.TabIndex = 21;
            this.AddOrderDetailbutton1.Text = "添加明细";
            this.AddOrderDetailbutton1.UseVisualStyleBackColor = true;
            this.AddOrderDetailbutton1.Click += new System.EventHandler(this.AddOrderDetailbutton1_Click);
            // 
            // ModifyOrderDetbutton1
            // 
            this.ModifyOrderDetbutton1.Location = new System.Drawing.Point(632, 795);
            this.ModifyOrderDetbutton1.Name = "ModifyOrderDetbutton1";
            this.ModifyOrderDetbutton1.Size = new System.Drawing.Size(217, 73);
            this.ModifyOrderDetbutton1.TabIndex = 20;
            this.ModifyOrderDetbutton1.Text = "修改明细";
            this.ModifyOrderDetbutton1.UseVisualStyleBackColor = true;
            this.ModifyOrderDetbutton1.Click += new System.EventHandler(this.ModifyOrderDetbutton1_Click);
            // 
            // goodslabel
            // 
            this.goodslabel.AutoSize = true;
            this.goodslabel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodslabel.Location = new System.Drawing.Point(91, 352);
            this.goodslabel.Name = "goodslabel";
            this.goodslabel.Size = new System.Drawing.Size(128, 37);
            this.goodslabel.TabIndex = 28;
            this.goodslabel.Text = "物品名";
            // 
            // goodstextBox1
            // 
            this.goodstextBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodstextBox1.Location = new System.Drawing.Point(225, 349);
            this.goodstextBox1.Name = "goodstextBox1";
            this.goodstextBox1.Size = new System.Drawing.Size(392, 50);
            this.goodstextBox1.TabIndex = 29;
            this.goodstextBox1.TextChanged += new System.EventHandler(this.goodstextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(54, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "物品价格";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(225, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 50);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "物品数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(113, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 37);
            this.label3.TabIndex = 35;
            this.label3.Text = "地址";
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddressBox.Location = new System.Drawing.Point(225, 633);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(392, 50);
            this.AddressBox.TabIndex = 36;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(113, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 37;
            this.label4.Text = "电话";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PhoneBox.Location = new System.Drawing.Point(225, 727);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(392, 50);
            this.PhoneBox.TabIndex = 38;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuantityBox.Location = new System.Drawing.Point(225, 537);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(392, 50);
            this.QuantityBox.TabIndex = 39;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(91, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 41;
            this.label5.Text = "客户号";
            // 
            // clientIDBox2
            // 
            this.clientIDBox2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clientIDBox2.Location = new System.Drawing.Point(225, 163);
            this.clientIDBox2.Name = "clientIDBox2";
            this.clientIDBox2.Size = new System.Drawing.Size(392, 50);
            this.clientIDBox2.TabIndex = 42;
            this.clientIDBox2.TextChanged += new System.EventHandler(this.clientIDBox2_TextChanged);
            // 
            // clientnametextBox2
            // 
            this.clientnametextBox2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clientnametextBox2.Location = new System.Drawing.Point(225, 254);
            this.clientnametextBox2.Name = "clientnametextBox2";
            this.clientnametextBox2.Size = new System.Drawing.Size(392, 50);
            this.clientnametextBox2.TabIndex = 43;
            this.clientnametextBox2.TextChanged += new System.EventHandler(this.clientnametextBox2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 892);
            this.Controls.Add(this.clientnametextBox2);
            this.Controls.Add(this.clientIDBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodstextBox1);
            this.Controls.Add(this.goodslabel);
            this.Controls.Add(this.Clientlabel);
            this.Controls.Add(this.OrderIDlabel);
            this.Controls.Add(this.OrderIDtextBox1);
            this.Controls.Add(this.AddOrderDetailbutton1);
            this.Controls.Add(this.ModifyOrderDetbutton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Clientlabel;
        private System.Windows.Forms.Label OrderIDlabel;
        private System.Windows.Forms.TextBox OrderIDtextBox1;
        private System.Windows.Forms.Button AddOrderDetailbutton1;
        private System.Windows.Forms.Button ModifyOrderDetbutton1;
        private System.Windows.Forms.Label goodslabel;
        private System.Windows.Forms.TextBox goodstextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientIDBox2;
        private System.Windows.Forms.TextBox clientnametextBox2;
    }
}