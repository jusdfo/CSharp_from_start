using System;
using System.Data;
using System.Drawing;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = button1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("单击了取消按钮");
        }
    }
}