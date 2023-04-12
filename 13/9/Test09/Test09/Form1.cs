using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test09
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
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_test", conn);
            sda.Fill(ds);
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from tb_man", conn);
            SqlCommandBuilder sbl = new SqlCommandBuilder(sda1);
            sda1.Fill(ds1);
            ds1.Merge(ds, true, MissingSchemaAction.AddWithKey);
            dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}