using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)        //判断输入的文件名是否为空
            {
                MessageBox.Show("文件名不能为空！");
            }
            else
            {
                if (File.Exists(textBox1.Text))       //使用File类的Exists方法判断要创建的文件是否存在
                {
                    MessageBox.Show("该文件已经存在");
                }
                else
                {
                    File.Create(textBox1.Text);       //使用File类的Create方法创建文件
                }
            }
        }
    }
}