using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

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
            //实例化IPEndPoint类对象
            IPEndPoint IPEPoint = new IPEndPoint(IPAddress.Parse(textBox1.Text), 80);
            //使用IPEndPoint类对象获取终结点的IP地址和端口号
            label2.Text = "IP地址："+IPEPoint.Address.ToString() + "\n端口号：" + IPEPoint.Port; 
        }
    }
}