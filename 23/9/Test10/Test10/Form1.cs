using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Uri address = new Uri(textBox1.Text);  //创建一个Uri类型的变量，用来存储要浏览的网页地址
            webBrowser1.Url = address;             //在WebBrowser控件中显示指定的网页
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)                   //判断是否按下回车键
            {
                if (textBox1.Text != "")
                {
                    button1_Click(sender, e);
                }
            }
        }
    }
}