using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

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
            //判断是否输入了主机地址
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入主机地址!");
            }
            else
            {
                textBox2.Text = string.Empty;
                //获取指定主机的IP地址
                IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
                //循环访问获得的IP地址
                foreach(IPAddress ip in ips)
                {
                    textBox2.Text = ip.ToString();//将得到的IP地址显示在文本框中
                }
                textBox3.Text = Dns.GetHostName();//获取本机名
                //根据指定的主机名获取DNS信息
                textBox4.Text = Dns.GetHostByName(Dns.GetHostName()).HostName;
            }
        }
    }
}