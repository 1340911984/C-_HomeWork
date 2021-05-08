using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
  public partial class FormParent : Form {
    FormMain formMain = new FormMain();
    public FormParent() {
      InitializeComponent();
    }

    private void FormParent_Load(object sender, EventArgs e) {
      formMain.TopLevel = false;
      formMain.FormBorderStyle = FormBorderStyle.None;
      formMain.Dock = DockStyle.Fill;
      formMain.ShowEditForm = this.ShowEditForm;//设置委托
      this.MainPage.Controls.Add(formMain);
      formMain.Show();
    }
    
    //显示编辑窗口
    public void ShowEditForm(FormEdit formEdit) {
      if (tabControlMain.TabCount > 1) {
        tabControlMain.TabPages.RemoveAt(1);
      }
      //新建标签页
      TabPage tabPage = new TabPage() { Text = "编辑订单" };
      tabControlMain.TabPages.Add(tabPage);
      tabControlMain.SelectTab(1);
      //在新标签页中显示编辑窗口
      formEdit.TopLevel = false;
      formEdit.FormBorderStyle = FormBorderStyle.None;
      formEdit.Dock = DockStyle.Fill;
      formEdit.CloseEditFrom = this.CloseEditForm;//设置委托
      tabPage.Controls.Add(formEdit);
      formEdit.Show();
    }

    //关闭编辑窗口
    public void CloseEditForm(FormEdit formEdit) {
      if (formEdit != null) formEdit.Close();
      if (tabControlMain.TabCount > 1) {
        tabControlMain.TabPages.RemoveAt(1);
      }
      formMain.QueryAll();

    }
  }
}
