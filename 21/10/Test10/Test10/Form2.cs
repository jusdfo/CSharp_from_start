using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
namespace Test10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int Sum;
        SqlConnection conn;
        private void CreateImage()
        {
            conn = new SqlConnection("server=XIAOKE\\XIAOKE;database=db_CSharp;uid=sa;pwd=");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(票数) from tb_vote", conn);
            Sum = (int)cmd.ExecuteScalar();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_vote", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int TP1 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());//第一个选项的票数
            int TP2 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());//第二个选项的票数
            int TP3 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());//第三个选项的票数
            int TP4 = Convert.ToInt32(ds.Tables[0].Rows[3][2].ToString());//第四个选项的票数
            float tp1 = Convert.ToSingle(Convert.ToSingle(TP1) * 100 / Convert.ToSingle(Sum));
            float tp2 = Convert.ToSingle(Convert.ToSingle(TP2) * 100 / Convert.ToSingle(Sum));
            float tp3 = Convert.ToSingle(Convert.ToSingle(TP3) * 100 / Convert.ToSingle(Sum));
            float tp4 = Convert.ToSingle(Convert.ToSingle(TP4) * 100 / Convert.ToSingle(Sum));
            int width = 300, height = 300;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                g.Clear(Color.White);
                Brush brush1 = new SolidBrush(Color.White);
                Brush brush2 = new SolidBrush(Color.Black);
                Brush brush3 = new SolidBrush(Color.Red);
                Brush brush4 = new SolidBrush(Color.Green);
                Brush brush5 = new SolidBrush(Color.Orange);
                Brush brush6 = new SolidBrush(Color.DarkBlue);
                Font font1 = new Font("Courier New", 16, FontStyle.Bold);
                Font font2 = new Font("Courier New", 8);
                g.FillRectangle(brush1, 0, 0, width, height);    //绘制背景图
                g.DrawString("投票结果", font1, brush2, new Point(90, 20));
                Point p1 = new Point(70, 50);
                Point p2 = new Point(230, 50);
                g.DrawLine(new Pen(Color.Black), p1, p2);
                //绘制文字
                g.DrawString("支付宝：", font2, brush2, new Point(40, 80));
                g.DrawString("微信支付：", font2, brush2, new Point(32, 110));
                g.DrawString("京东白条：", font2, brush2, new Point(32, 140));
                g.DrawString("小度钱包：", font2, brush2, new Point(32, 170));
                //绘制柱形图
                g.FillRectangle(brush3, 95, 80, tp1, 17);
                g.FillRectangle(brush4, 95, 110, tp2, 17);
                g.FillRectangle(brush5, 95, 140, tp3, 17);
                g.FillRectangle(brush6, 95, 170, tp4, 17);
                //绘制所有选项的票数显示
                g.DrawRectangle(new Pen(Color.Green), 10, 210, 280, 80);  //绘制范围框
                g.DrawString("支付宝：" + TP1.ToString() + "票", font2, brush2, new Point(15, 220));
                g.DrawString("微信支付：" + TP2.ToString() + "票", font2, brush2, new Point(150, 220));
                g.DrawString("京东白条：" + TP3.ToString() + "票", font2, brush2, new Point(15, 260));
                g.DrawString("小度钱包：" + TP4.ToString() + "票", font2, brush2, new Point(150, 260));
                pictureBox1.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            CreateImage();
        }
    }
}