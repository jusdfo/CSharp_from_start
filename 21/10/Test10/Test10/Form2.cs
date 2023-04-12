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
            SqlCommand cmd = new SqlCommand("select sum(Ʊ��) from tb_vote", conn);
            Sum = (int)cmd.ExecuteScalar();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_vote", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int TP1 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());//��һ��ѡ���Ʊ��
            int TP2 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());//�ڶ���ѡ���Ʊ��
            int TP3 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());//������ѡ���Ʊ��
            int TP4 = Convert.ToInt32(ds.Tables[0].Rows[3][2].ToString());//���ĸ�ѡ���Ʊ��
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
                g.FillRectangle(brush1, 0, 0, width, height);    //���Ʊ���ͼ
                g.DrawString("ͶƱ���", font1, brush2, new Point(90, 20));
                Point p1 = new Point(70, 50);
                Point p2 = new Point(230, 50);
                g.DrawLine(new Pen(Color.Black), p1, p2);
                //��������
                g.DrawString("֧������", font2, brush2, new Point(40, 80));
                g.DrawString("΢��֧����", font2, brush2, new Point(32, 110));
                g.DrawString("����������", font2, brush2, new Point(32, 140));
                g.DrawString("С��Ǯ����", font2, brush2, new Point(32, 170));
                //��������ͼ
                g.FillRectangle(brush3, 95, 80, tp1, 17);
                g.FillRectangle(brush4, 95, 110, tp2, 17);
                g.FillRectangle(brush5, 95, 140, tp3, 17);
                g.FillRectangle(brush6, 95, 170, tp4, 17);
                //��������ѡ���Ʊ����ʾ
                g.DrawRectangle(new Pen(Color.Green), 10, 210, 280, 80);  //���Ʒ�Χ��
                g.DrawString("֧������" + TP1.ToString() + "Ʊ", font2, brush2, new Point(15, 220));
                g.DrawString("΢��֧����" + TP2.ToString() + "Ʊ", font2, brush2, new Point(150, 220));
                g.DrawString("����������" + TP3.ToString() + "Ʊ", font2, brush2, new Point(15, 260));
                g.DrawString("С��Ǯ����" + TP4.ToString() + "Ʊ", font2, brush2, new Point(150, 260));
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