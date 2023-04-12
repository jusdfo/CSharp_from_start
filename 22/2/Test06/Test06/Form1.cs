using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            //启用"打印到文件"复选框
            printDialog1.AllowPrintToFile = true;
            //显示“当前项”按钮
            printDialog1.AllowCurrentPage = true;
            //启用"选择按钮"
            printDialog1.AllowSelection = true;
            //启用"页"按钮
            printDialog1.AllowSomePages = true;
            printDialog1.ShowDialog();
        }
    }
}