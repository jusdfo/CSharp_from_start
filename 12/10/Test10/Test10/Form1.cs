﻿using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test10
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
            TreeNode Ntn1 = new TreeNode("支付宝");
            TreeNode Ntn2 = new TreeNode("微信支付");
            TreeNode Ntn3 = new TreeNode("京东白条");
            tn1.Nodes.Add(Ntn1);
            tn1.Nodes.Add(Ntn2);
            tn1.Nodes.Add(Ntn3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "名称")
            {
                MessageBox.Show("请选择要删除的子节点");
            }
            else
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
    }
}