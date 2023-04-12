using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("项目不能为空");
            }
            else
            {
                listView1.Items.Add(textBox1.Text.Trim());
            }
        }
    }
}