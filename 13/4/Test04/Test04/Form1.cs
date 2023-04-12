using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test04
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
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update tb_command set 奖金=50 where 性别='女'";
            cmd.CommandType = CommandType.Text;
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            label2.Text = "共有" + i.ToString() + "名女员工获得奖金";
        }
    }
}