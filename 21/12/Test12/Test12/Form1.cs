using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateImage()
        {
            //连数据库
            SqlConnection conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            conn.Open();
            //计算公司员工总和
            string str2 = "SELECT SUM(人数) AS Number FROM tb_age";
            SqlCommand cmd = new SqlCommand(str2, conn);
            int Sum = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_age", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //获取20-25岁员工人数
            int man20to25 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
            //获取26-30岁员工人数
            int man26to30 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());
            //获取31-40岁员工人数
            int man31to40 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());
            //创建画图对象
            int width = 400, height = 450;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                //清空背景色
                g.Clear(Color.White);
                Pen pen1 = new Pen(Color.Red);
                Brush brush1 = new SolidBrush(Color.PowderBlue);
                Brush brush2 = new SolidBrush(Color.Blue);
                Brush brush3 = new SolidBrush(Color.Wheat);
                Brush brush4 = new SolidBrush(Color.Orange);
                Font font1 = new Font("Courier New", 16, FontStyle.Bold);
                Font font2 = new Font("Courier New", 8);
                g.FillRectangle(brush1, 0, 0, width, height);    //绘制背景图
                g.DrawString("公司员工年龄比例饼形图", font1, brush2, new Point(80, 20));  //书写标题
                int piex = 100, piey = 60, piew = 200, pieh = 200;
                //20-25岁员工在圆中分配的角度
                float angle1 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man20to25));
                //26-30岁员工在圆中分配的角度
                float angle2 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man26to30));
                //31-40岁员工在圆中分配的角度
                float angle3 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man31to40));
                g.FillPie(brush2, piex, piey, piew, pieh, 0, angle1);       //绘制20-25岁员工所占比例
                g.FillPie(brush3, piex, piey, piew, pieh, angle1, angle2);  //绘制26-30岁员工所占比例
                g.FillPie(brush4, piex, piey, piew, pieh, angle1 + angle2, angle3);  //绘制31-40岁员工所占比例
                //绘制标识
                g.DrawRectangle(pen1, 50, 300, 310, 130);  //绘制范围框
                g.FillRectangle(brush2, 90, 320, 20, 10);  //绘制小矩形
                g.DrawString("20-25岁员工占公司总人数比例:" + Convert.ToSingle(man20to25) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 320);
                g.FillRectangle(brush3, 90, 360, 20, 10);
                g.DrawString("26-30岁员工占公司总人数比例:" + Convert.ToSingle(man26to30) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 360);
                g.FillRectangle(brush4, 90, 400, 20, 10);
                g.DrawString("31-40岁员工占公司总人数比例:" + Convert.ToSingle(man31to40) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 400);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBox1.Image = bitmap;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CreateImage();
        }
    }
}