using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sda;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            SqlCommand cmd = new SqlCommand("select * from tb_command", conn);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            ds = new DataSet();
            sda.Fill(ds, "cs");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["cs"];
            sda.FillSchema(dt, SchemaType.Mapped);
            DataRow dr = dt.Rows.Find(txtNo.Text);
            dr["姓名"] = txtName.Text.Trim();
            dr["性别"] = this.txtSex.Text.Trim();
            dr["年龄"] = this.txtAge.Text.Trim();
            dr["奖金"] = this.txtJJ.Text.Trim();
            SqlCommandBuilder cmdbuider = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtSex.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtAge.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtJJ.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }
    }
}