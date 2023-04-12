using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始")
            {
                timer1.Enabled = true;
                button1.Text ="停止";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "开始";
            }
        }
    }
}