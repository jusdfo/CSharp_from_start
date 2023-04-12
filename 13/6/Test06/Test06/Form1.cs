using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from " + textBox1.Text.Trim(), conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("数据表中有值");
                }
                else
                {
                    MessageBox.Show("数据表中没有任何数据");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}