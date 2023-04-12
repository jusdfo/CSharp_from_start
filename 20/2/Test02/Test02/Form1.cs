using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)                //判断输入的文件夹名称是否为空
            {
                MessageBox.Show("文件夹名称不能为空！");
            }
            else
            {
                if (Directory.Exists(textBox1.Text))          //使用Directory类的Exists方法判断要创建的文件夹是否存在
                {
                    MessageBox.Show("该文件夹已经存在");
                }
                else
                {
                    Directory.CreateDirectory(textBox1.Text);  //使用Directory类的CreateDirectory方法创建文件夹
                }
            }
        }
    }
}