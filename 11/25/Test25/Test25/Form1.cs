using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("添加项目不能为空");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "共选择了：" + listBox1.SelectedItems.Count.ToString() + "项";
        }
    }
}