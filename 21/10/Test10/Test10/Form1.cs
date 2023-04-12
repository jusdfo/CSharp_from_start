using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test10
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
            rdbA.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
                string sqlstr = "";
                if (rdbA.Checked)
                {
                    sqlstr = "update tb_vote set 票数=票数+1 where 选项='" + rdbA.Text + "'";
                }
                if (rdbB.Checked)
                {
                    sqlstr = "update tb_vote set 票数=票数+1 where 选项='" + rdbB.Text + "'";
                }
                if (rdbC.Checked)
                {
                    sqlstr = "update tb_vote set 票数=票数+1 where 选项='" + rdbC.Text + "'";
                }
                if (rdbD.Checked)
                {
                    sqlstr = "update tb_vote set 票数=票数+1 where 选项='" + rdbD.Text + "'";
                }
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                int i = (int)cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("投票成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}