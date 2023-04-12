using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tn1 = treeView1.Nodes.Add("组织结构");
            TreeNode Ntn1 = new TreeNode("C#部门");
            TreeNode Ntn2 = new TreeNode("ASP.NET部门");
            TreeNode Ntn3 = new TreeNode("VB部门");
            tn1.Nodes.Add(Ntn1);
            tn1.Nodes.Add(Ntn2);
            tn1.Nodes.Add(Ntn3);
            imageList1.Images.Add(Image.FromFile("1.png"));
            imageList1.Images.Add(Image.FromFile("2.png"));
            treeView1.ImageList = imageList1;
            imageList1.ImageSize = new Size(16,16);
            treeView1.ImageIndex = 0;
            treeView1.SelectedImageIndex = 1;
        }
    }
}