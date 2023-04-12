using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;//初始化Label标签
            //获得指定主机的IP地址族
            IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
            //循环遍历得到的IP地址
            foreach (IPAddress ip in ips)
            {
                //在Label标签中显示得到的IP地址信息
                label2.Text = "网际协议地址：" + ip.Address + "\nIP地址的地址族："
                    + ip.AddressFamily.ToString() + "\n是否IPv6链接本地地址：" + ip.IsIPv6LinkLocal;
            }
        }
    }
}