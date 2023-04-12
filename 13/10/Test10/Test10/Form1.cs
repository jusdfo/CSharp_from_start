using System;
using System.Data;
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
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            SqlCommand cmd = new SqlCommand("select * from tb_test", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            ds = new DataSet();
            sda.Fill(ds, "test");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds1 = ds.Copy();
            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}