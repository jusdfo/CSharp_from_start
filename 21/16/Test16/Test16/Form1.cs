using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
namespace Test16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连数据库
            SqlConnection sqlcon = new SqlConnection("Server=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=");
            string P_str_sel = "select *  from tb_02";
            SqlDataAdapter myda1 = new SqlDataAdapter(P_str_sel, sqlcon);
            DataSet myds1 = new DataSet();
            myda1.Fill(myds1);
            //计算男、女总和
            string P_str_sumNum = "select sum(boyNum+girlNum) as sumNum FROM tb_02";
            SqlDataAdapter myda2 = new SqlDataAdapter(P_str_sumNum, sqlcon);
            DataSet myds2 = new DataSet();
            myda2.Fill(myds2);
            int P_int_sum = Convert.ToInt32(myds2.Tables[0].Rows[0][0].ToString());
            //获取男员工数目
            int P_int_boy = Convert.ToInt32(myds1.Tables[0].Rows[0][0].ToString());
            //获取女员工数目
            int P_int_girl = Convert.ToInt32(myds1.Tables[0].Rows[0][1].ToString());
            Graphics graphics = this.CreateGraphics();
            try
            {
                graphics.Clear(Color.White);
                Pen pen1 = new Pen(Color.Red);
                Brush brush1 = new SolidBrush(Color.YellowGreen);
                Brush brush2 = new SolidBrush(Color.Blue);
                Brush brush3 = new SolidBrush(Color.Brown);
                Font font1 = new Font("Courier New", 16, FontStyle.Bold);
                Font font2 = new Font("Courier New", 8);
                graphics.FillRectangle(brush1, 0, 0, 370, 350);    //绘制背景
                graphics.DrawString("公司员工男女比例分析", font1, brush2, new Point(60, 20));  //书写标题
                //男员工在圆中分配的角度
                float angle1 = Convert.ToSingle((360 * (Convert.ToSingle(P_int_boy) / Convert.ToSingle(P_int_sum))));
                //女员工在圆中分配的角度
                float angle2 = Convert.ToSingle((360 * (Convert.ToSingle(P_int_girl) / Convert.ToSingle(P_int_sum))));
                graphics.FillPie(brush2, 100, 60, 180, 180, 0, angle1);  //绘制男员工所占比例
                graphics.FillPie(brush3, 100, 60, 180, 180, angle1, angle2);  //绘制女员工所占比例
                //绘制标识
                graphics.DrawRectangle(pen1, 50, 255, 260, 50);  //绘制范围框
                graphics.FillRectangle(brush2, 85, 265, 20, 10);  //绘制小矩形
                graphics.DrawString("男员工占公司总人数比例:" + Convert.ToInt32(P_int_boy) * 100 / Convert.ToInt32(P_int_sum) + "%", font2, brush2, 120, 265);
                graphics.FillRectangle(brush3, 85, 285, 20, 10);
                graphics.DrawString("女员工占公司总人数比例:" + Convert.ToInt32(P_int_girl) * 100 / Convert.ToInt32(P_int_sum) + "%", font2, brush3, 120, 285);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            graphics.Dispose();
        }
    }
}