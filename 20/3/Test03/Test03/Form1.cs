using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)           //判断输入的文件名称是否为空
            {
                MessageBox.Show("文件名称不能为空！");
            }
            else
            {
                FileInfo finfo = new FileInfo(textBox1.Text);
                if (finfo.Exists)                        //使用FileInfo对象的Exists属性判断要创建的文件是否存在
                {
                    MessageBox.Show("该文件已经存在");
                }
                else
                {
                    finfo.Create();                       //使用FileInfo对象的Create方法创建文件
                }
            }
        }
    }
}