using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Groups.Add(new ListViewGroup("网游", HorizontalAlignment.Left));
            listView1.Groups.Add(new ListViewGroup("单机", HorizontalAlignment.Left));
            listView1.Items.Add("王者荣耀");
            listView1.Items.Add("绝地求生");
            listView1.Items.Add("穿越火线");
            listView1.Items.Add("迷你世界");
            listView1.Items.Add("天天斗地主");
            listView1.Items.Add("汤姆猫跑酷");
            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[0];
            listView1.Items[3].Group = listView1.Groups[1];
            listView1.Items[4].Group = listView1.Groups[1];
            listView1.Items[5].Group = listView1.Groups[1];
        }
    }
}