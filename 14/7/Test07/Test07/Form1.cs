using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=XIAOKE\\XIAOKE;uid=sa;pwd=;database=db_CSharp");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_emp", con);
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            int Cont = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);//选取单元格的数目即有行又有列
            if (Cont > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))//判断是否选重了所有的值。
                {
                    MessageBox.Show("你选重了所有的值", "全部选中了");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < Cont; i++)
                    {
                        sb.Append("Row: ");
                        sb.Append(dataGridView1.SelectedCells[i].RowIndex.ToString());
                        sb.Append(", Column: ");
                        sb.Append(dataGridView1.SelectedCells[i].ColumnIndex.ToString());
                        sb.Append(Environment.NewLine);
                    }
                    sb.Append("Total: " + Cont.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }
    }
}