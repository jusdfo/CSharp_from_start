using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinqShowDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=;";//定义数据库连接字符串
            SqlConnection sqlcon;//声明SqlConnection对象
            SqlDataAdapter sqlda;//声明SqlDataAdapter对象
            DataSet myds;//声明DataSet数据集对象
            sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
            sqlda = new SqlDataAdapter("select * from tb_Salary", sqlcon);//实例化数据库桥接器对象
            myds = new DataSet();//实例化数据集对象
            sqlda.Fill(myds, "tb_Salary");//填充DataSet数据集
            var query = from salary in myds.Tables["tb_Salary"].AsEnumerable()//使用LINQ从数据集中查询所有数据
                        select salary;
            DataTable myDTable = query.CopyToDataTable<DataRow>();//将查询结果转化为DataTable对象
            dataGridView1.DataSource = myDTable;//显示查询到的数据集中的信息
        }
    }
}
