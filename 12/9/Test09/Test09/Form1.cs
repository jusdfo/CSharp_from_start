using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tn1 = treeView1.Nodes.Add("名称");
            TreeNode tn2 = treeView1.Nodes.Add("性别");
            TreeNode tn3 = treeView1.Nodes.Add("年龄");
            TreeNode Ntn1 = new TreeNode("马云");
            TreeNode Ntn2 = new TreeNode("董明珠");
            TreeNode Ntn3 = new TreeNode("马化腾");
            tn1.Nodes.Add(Ntn1);
            tn1.Nodes.Add(Ntn2);
            tn1.Nodes.Add(Ntn3);
            TreeNode Stn1 = new TreeNode("男");
            TreeNode Stn2 = new TreeNode("女");
            TreeNode Stn3 = new TreeNode("男");
            tn2.Nodes.Add(Stn1);
            tn2.Nodes.Add(Stn2);
            tn2.Nodes.Add(Stn3);
            TreeNode Atn1 = new TreeNode("28");
            TreeNode Atn2 = new TreeNode("27");
            TreeNode Atn3 = new TreeNode("26");
            tn3.Nodes.Add(Atn1);
            tn3.Nodes.Add(Atn2);
            tn3.Nodes.Add(Atn3);
        }
    }
}