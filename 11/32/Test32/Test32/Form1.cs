using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Title = "新增选项卡 " + (tabControl1.TabCount + 1).ToString();
            TabPage MyTabPage = new TabPage(Title);
            tabControl1.TabPages.Add(MyTabPage);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MessageBox.Show("请选择要删除的选项卡");
            }
            else
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }
    }
}