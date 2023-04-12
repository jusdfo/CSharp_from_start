using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            listView1.View = View.Tile;
            listView1.LargeImageList = imageList1;
            //向imageList1控件中添加5张图片
            imageList1.Images.Add(Image.FromFile("01.png"));
            imageList1.Images.Add(Image.FromFile("02.png"));
            imageList1.Images.Add(Image.FromFile("03.png"));
            imageList1.Images.Add(Image.FromFile("04.png"));
            imageList1.Images.Add(Image.FromFile("05.png"));
            listView1.Items.Add("支付宝");
            listView1.Items.Add("微信支付");
            listView1.Items.Add("小度钱包");
            listView1.Items.Add("京东白条");
            listView1.Items.Add("苏宁任性付");
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 2;
            listView1.Items[3].ImageIndex = 3;
            listView1.Items[4].ImageIndex = 4;
            listView1.TileSize = new Size(100, 50);
        }
    }
}