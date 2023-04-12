using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("控件的选择状态发生改变");
        }
    }
}