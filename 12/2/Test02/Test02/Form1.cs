using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = 200;
            pictureBox1.Height = 165;
            string Path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            Path += @"\01.jpg";
            Image img = Image.FromFile(Path, true);
            imageList1.Images.Add(img);
            imageList1.ImageSize = new Size(200,165);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("没有图像");
            }
            else
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            imageList1.Images.RemoveAt(0);
            pictureBox1.Image = null;
        }
    }
}