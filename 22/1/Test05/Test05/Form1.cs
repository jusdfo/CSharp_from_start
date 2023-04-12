using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            //启用边距
            this.pageSetupDialog1.AllowMargins = true;
            this.pageSetupDialog1.AllowOrientation = true;
            this.pageSetupDialog1.AllowPaper = true;
            this.pageSetupDialog1.AllowPrinter = true;
            //显示页面设置对话框
            this.pageSetupDialog1.ShowDialog();
        }
    }
}