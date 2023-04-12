using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = Application.StartupPath.Substring(0,Application.StartupPath.Substring(0,Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            Path += @"\01.jpg";
            string Path2 = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            Path2 += @"\02.jpg";
            Image Mimg=Image.FromFile(Path,true);
            imageList1.Images.Add(Mimg);
            Image Mimg2 = Image.FromFile(Path2, true);
            imageList1.Images.Add(Mimg2);
            imageList1.ImageSize = new Size(200,165);
            pictureBox1.Width = 200;
            pictureBox1.Height = 165;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }
    }
}