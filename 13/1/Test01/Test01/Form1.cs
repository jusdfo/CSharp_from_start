using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test01
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
                MessageBox.Show("请输入要连接的数据库名称");
            }
            else
            {
                try
                {
                    string ConStr = "server=XIAOKE\\XIAOKE;database=" + textBox1.Text.Trim() + ";uid=sa;pwd=";
                    SqlConnection conn = new SqlConnection(ConStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        label2.Text = "数据库【" + textBox1.Text.Trim() + "】已经连接并打开";
                    }
                }
                catch
                {
                    MessageBox.Show("连接数据库失败");
                }
            }
        }
    }
}