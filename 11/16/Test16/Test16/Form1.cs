using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test16
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
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }
    }
}