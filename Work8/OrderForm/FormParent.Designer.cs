namespace OrderForm {
  partial class FormParent {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.MainPage = new System.Windows.Forms.TabPage();
      this.tabControlMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControlMain.Controls.Add(this.MainPage);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 0);
      this.tabControlMain.Name = "tabControl1";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(800, 450);
      this.tabControlMain.TabIndex = 0;
      // 
      // MainPage
      // 
      this.MainPage.Location = new System.Drawing.Point(4, 22);
      this.MainPage.Name = "MainPage";
      this.MainPage.Padding = new System.Windows.Forms.Padding(3);
      this.MainPage.Size = new System.Drawing.Size(792, 424);
      this.MainPage.TabIndex = 0;
      this.MainPage.Text = "订单管理";
      this.MainPage.UseVisualStyleBackColor = true;
      // 
      // FormParent
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControlMain);
      this.Name = "FormParent";
      this.Text = "FormParent";
      this.Load += new System.EventHandler(this.FormParent_Load);
      this.tabControlMain.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage MainPage;
  }
}