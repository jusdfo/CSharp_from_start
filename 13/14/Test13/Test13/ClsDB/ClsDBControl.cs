using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Test13.ClsDB
{
    class ClsDBControl
    {
        private SqlConnection con;

        #region//生成连接对象
        public SqlConnection ConDB()
        {
            con = new SqlConnection("server=XIAOKE\\XIAOKE;uid=sa;pwd=;database=db_CSharp");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        #endregion

        public DataSet dsResult(int currentIndex)
        {
            int pageSize = 1;
            string orderSQL = "SELECT * FROM tb_People ORDER BY tb_PID";
            SqlDataAdapter adapter = new SqlDataAdapter(orderSQL, ConDB());
            DataSet dataSet = new DataSet("tb_People");
            adapter.Fill(dataSet, currentIndex, pageSize, "tb_People");
            return dataSet;
        }

        public int Max()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from tb_people", ConDB());
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
    }
}
