using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
namespace Test15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateImage(int P_int_year)
        {
            int height = 400, width = 600;
            Bitmap image = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(image);
            try
            {
                graphics.Clear(Color.White);
                Font font = new Font("Arial", 9, FontStyle.Regular);
                Font font1 = new Font("宋体", 20, FontStyle.Regular);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
                graphics.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
                Brush brush1 = new SolidBrush(Color.Blue);
                string P_str_sum = "SELECT * FROM tb_03 WHERE yearID=" + P_int_year + "";
                SqlConnection sqlcon = new SqlConnection("Server=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(P_str_sum, sqlcon);
                SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                sqlread.Read();
                if (sqlread.HasRows)
                {
                    graphics.DrawString("" + P_int_year + "年各月份网站访问人数", font1, brush1, new PointF(130, 30));
                }
                sqlread.Close();
                //画图片的边框线
                graphics.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);
                Pen mypen = new Pen(brush, 1);
                //绘制横向线条
                int x = 100;
                for (int i = 0; i < 11; i++)
                {
                    graphics.DrawLine(mypen, x, 80, x, 340);
                    x = x + 40;
                }
                Pen mypen1 = new Pen(Color.Blue, 2);
                Pen mypen2 = new Pen(Color.Red, 2);
                graphics.DrawLine(mypen1, x - 480, 80, x - 480, 340);
                //绘制纵向线条
                int y = 125;
                for (int i = 0; i < 9; i++)
                {
                    graphics.DrawLine(mypen, 60, y, 540, y);
                    y = y + 24;
                }
                graphics.DrawLine(mypen1, 60, y, 540, y);
                //x轴
                String[] n = {"  一月", "  二月", "  三月", "  四月", "  五月", "  六月", "  七月",
                     "  八月", "  九月", "  十月", "十一月", "十二月"};
                x = 65;
                for (int i = 0; i < 12; i++)
                {
                    graphics.DrawString(n[i].ToString(), font, Brushes.Red, x, 348); //设置文字内容及输出位置
                    x = x + 40;
                }
                //y轴
                String[] m = { " 900人", " 800人", " 700人", " 600人", " 500人", " 400人", " 300人",
                     " 200人", " 100人", " 0人"};
                y = 120;
                for (int i = 0; i < 10; i++)
                {
                    graphics.DrawString(m[i].ToString(), font, Brushes.Red, 20, y); //设置文字内容及输出位置
                    y = y + 24;
                }
                int[] Count = new int[12];
                string P_str_yearID = "SELECT * FROM tb_03 WHERE yearID=" + P_int_year + "";
                SqlDataAdapter myda = new SqlDataAdapter(P_str_yearID, sqlcon);
                DataSet myds = new DataSet();
                myda.Fill(myds);
                for (int j = 0; j < 12; j++)
                {
                    Count[j] = Convert.ToInt32(myds.Tables[0].Rows[0][j + 1].ToString()) * 14 / 100;
                }
                SolidBrush mybrush = new SolidBrush(Color.Red);
                Point[] myPoint = new Point[12];
                myPoint[0].X = 60; myPoint[0].Y = 340 - Count[0];
                myPoint[1].X = 100; myPoint[1].Y = 340 - Count[1];
                myPoint[2].X = 140; myPoint[2].Y = 340 - Count[2];
                myPoint[3].X = 180; myPoint[3].Y = 340 - Count[3];
                myPoint[4].X = 220; myPoint[4].Y = 340 - Count[4];
                myPoint[5].X = 260; myPoint[5].Y = 340 - Count[5];
                myPoint[6].X = 300; myPoint[6].Y = 340 - Count[6];
                myPoint[7].X = 340; myPoint[7].Y = 340 - Count[7];
                myPoint[8].X = 380; myPoint[8].Y = 340 - Count[8];
                myPoint[9].X = 420; myPoint[9].Y = 340 - Count[9];
                myPoint[10].X = 460; myPoint[10].Y = 340 - Count[10];
                myPoint[11].X = 500; myPoint[11].Y = 340 - Count[11];
                graphics.DrawLines(mypen2, myPoint);  //绘制折线
                System.IO.MemoryStream MStream = new System.IO.MemoryStream();
                image.Save(MStream, System.Drawing.Imaging.ImageFormat.Gif);
                Bitmap bitMange = new Bitmap(image);
                pictureBox1.Image = bitMange;//将绘制的折线图片显示在pictureBox控件中

            }
            finally
            {
                graphics.Dispose();
                image.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                CreateImage(Convert.ToInt32(comboBox1.Text)); //调用绘图方法
            }
            else
            {
                MessageBox.Show("请选择商品销售年份");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string P_str_sum = "SELECT * FROM tb_03";
            SqlConnection sqlcon = new SqlConnection("Server=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=");
            SqlDataAdapter myda = new SqlDataAdapter(P_str_sum, sqlcon);
            DataSet myds = new DataSet();
            myda.Fill(myds);
            comboBox1.DataSource = myds.Tables[0].DefaultView;
            comboBox1.DisplayMember = "yearid";
        }
    }
}