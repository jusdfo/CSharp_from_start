using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection con;

        #region//生成连接对象
        public SqlConnection ConDB()
        {
            con = new SqlConnection("server=XIAOKE;uid=sa;pwd=;database=db_CSharp");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        #endregion

        public bool insertDB(String sql)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = sql;//设置SQL语句
                    cmd.Connection = ConDB();//调用打开数据库连接方法
                    cmd.ExecuteNonQuery();//执行
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strSql = "insert into tb_people values('" + this.textBox1.Text.Trim().ToString() + "','" +
            this.textBox2.Text.Trim().ToString() + "','" + this.textBox3.Text.Trim().ToString() + "')";
            if (insertDB(strSql))
            {
                MessageBox.Show("OK");
            }
        }
    }
}