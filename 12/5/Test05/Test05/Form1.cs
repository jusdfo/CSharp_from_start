using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("支付宝");
            listView1.Items.Add("微信支付");
            listView1.Items.Add("小度钱包");
            listView1.Items[2].Selected = true;
        }
    }
}