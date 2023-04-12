using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open || textBox1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select count(*) from " + textBox1.Text.Trim();
                    cmd.CommandType = CommandType.Text;
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    label2.Text = "数据表中共有：" + i.ToString() + "条数据";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}