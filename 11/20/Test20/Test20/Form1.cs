using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("RadioButton1控件的选中状态被更改");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}