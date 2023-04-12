using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("项目不能为空");
            }
            else
            {
                listView1.Items.Add(textBox1.Text.Trim());
                textBox1.Text = "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("项目中已经没有项目");
            }
            else
            {
                listView1.Items.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的项");
            }
            else
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.SelectedItems.Clear();
            }
        }
    }
}