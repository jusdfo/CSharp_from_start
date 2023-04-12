using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数据库名称");
            }
            else
            {
                try
                {
                    string str = "server=XIAOKE\\XIAOKE;database=" + textBox1.Text.Trim() + ";uid=sa;pwd=";
                    conn = new SqlConnection(str);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("连接成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Text = "";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    str = "数据库已经成功关闭\n";
                }
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    str += "数据库已经成功打开\n";
                }
                richTextBox1.Text = str;
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Dispose();
                conn.Open();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }
    }
}