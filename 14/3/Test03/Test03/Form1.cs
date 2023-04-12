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
        SqlDataAdapter adapter;
        int intindex = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;uid=sa;pwd=;database=db_CSharp");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_emp", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 84;
            }
            button1.Enabled = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }
        private DataTable dbconn(string strSql)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            this.adapter = new SqlDataAdapter(strSql, conn);
            DataTable dtSelect = new DataTable();
            int rnt = this.adapter.Fill(dtSelect);
            return dtSelect;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dbUpdate())
            {
                MessageBox.Show("修改成功！");
            }
        }
        private Boolean dbUpdate()
        {
            string strSql = "select * from tb_emp";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)this.dataGridView1.DataSource;
            dtUpdate.ImportRow(dtShow.Rows[intindex]);
            SqlCommandBuilder CommandBuiler;
            CommandBuiler = new SqlCommandBuilder(this.adapter);
            this.adapter.Update(dtUpdate);
            dtUpdate.AcceptChanges();
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intindex = e.RowIndex;
        }
    }
}