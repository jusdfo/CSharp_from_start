using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Test11
{
    class Program
    {
        static string strCon = "Data Source=(local);Database=Northwind;Uid=sa;Pwd=";
        static SqlConnection sqlcon = null;
        static void Main(string[] args)
        {
            Thread myThreadCon = new Thread(new ThreadStart(ThreadCon));//使用自定义方法ThreadCon声明线程
            Thread myThreadInsert = new Thread(new ThreadStart(ThreadInsert));//使用自定义方法ThreadInsert声明线程
            myThreadCon.Start();//首先执行连接数据库并获得数据的线程
            myThreadCon.Suspend();//挂起已经执行的线程
            myThreadInsert.Start();//执行向数据库中插入数据的线程
            myThreadCon.Resume();//恢复执行连接数据库并获得数据的线程
        }
        static void ThreadCon()
        {
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Region", sqlcon);
            DataSet myds = new DataSet();
            sqlda.Fill(myds);
            for (int i = 0; i < myds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(myds.Tables[0].Rows[i][0].ToString() + " " + myds.Tables[0].Rows[i][1].ToString());
            }
        }
        static void ThreadInsert()
        {
            sqlcon = new SqlConnection(strCon);
            SqlCommand sqlcom = new SqlCommand("insert into Region(RegionID,RegionDescription) values(5,'EastNorth')", sqlcon);
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            Console.WriteLine("插入成功");
        }
    }
}
