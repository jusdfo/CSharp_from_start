using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("CheckBox控件被选中");
            }
            else
            {
                MessageBox.Show("CheckBox控件选择被取消");
            }
        }
    }
}