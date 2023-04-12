using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            if (textBox1.Text == string.Empty)           //判断输入的文件夹名称是否为空
            {
                MessageBox.Show("文件夹名称不能为空！");
            }
            else
            {
                DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text);  //实例化DirectoryInfo类对象
                if (dinfo.Exists)                        //使用DirectoryInfo对象的Exists属性判断要创建的文件夹是否存在
                {
                    MessageBox.Show("该文件夹已经存在");
                }
                else
                {
                    dinfo.Create();                      //使用DirectoryInfo对象的Create方法创建文件夹
                }
            }
        }
    }
}