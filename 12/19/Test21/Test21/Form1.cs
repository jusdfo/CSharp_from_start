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
        private int a,b,c;
        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "不能为空");
            }
            else
            {
                errorProvider1.SetError(textBox1,"");
                a = 1;
            }
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "不能为空");
            }
            else
            {
                try
                {
                    int x = Int32.Parse(textBox2.Text);
                    errorProvider2.SetError(textBox2,"");
                    b = 1;
                }
                catch
                {
                    errorProvider2.SetError(textBox2, "请输入一个数");
                }
            }
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "不能为空");
            }
            else
            {
                errorProvider3.SetError(textBox3, "");
                c = 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a + b + c == 3)
            {
                MessageBox.Show("数据录入成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}