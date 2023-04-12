using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ImageList = imageList1;
            tabPage1.ImageIndex = 0;
            tabPage1.Text = "选项卡1";
            tabPage2.ImageIndex = 0;
            tabPage2.Text = "选项卡2";
        }
    }
}