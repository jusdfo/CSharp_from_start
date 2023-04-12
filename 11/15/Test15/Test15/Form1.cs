using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.Add("支付宝");
            comboBox1.Items.Add("微信支付");
            comboBox1.Items.Add("京东白条");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
        }
    }
}