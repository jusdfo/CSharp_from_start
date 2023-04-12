using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 20;
            numericUpDown1.Minimum = 1;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "当前控件中显示的数值：" + numericUpDown1.Value;
        }
    }
}