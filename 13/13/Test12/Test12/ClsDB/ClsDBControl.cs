using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Test12.ClsDB
{
    class ClsDBControl
    {
        private SqlConnection con;

        #region//�������Ӷ���
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

        public bool updateDB(String sql)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = sql;//����SQL���
                    cmd.Connection = ConDB();//���ô����ݿ����ӷ���
                    cmd.ExecuteNonQuery();//ִ��
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
