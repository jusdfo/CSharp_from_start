using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化一个TcpListener对象，并初始化为空
            TcpListener tcplistener = null;
            //实例化一个IPAddress对象，用来表示网络IP地址
            IPAddress ipaddress = IPAddress.Parse(textBox1.Text);
            //定义一个int类型变量，用来存储端口号
            int port = Convert.ToInt32(textBox2.Text);
            tcplistener = new TcpListener(ipaddress, port);     //初始化TcpListener对象
            tcplistener.Start();                                //开始TcpListener侦听
            richTextBox1.Text = "等待连接...\n";
            TcpClient tcpclient = null;                         //实例化一个TcpClient对象，并赋值为空
            if (tcplistener.Pending())                          //判断是否有挂起的连接请求
                tcpclient = tcplistener.AcceptTcpClient();      //使用AcceptTcpClient初始化TcpClient对象
            else
                tcpclient = new TcpClient(textBox1.Text, port); //使用TcpClient的构造函数初始化TcpClient对象
            richTextBox1.Text += "连接成功！\n";
            tcpclient.Close();                                  //关闭TcpClient连接
            tcplistener.Stop();                                 //停止TcpListener侦听
        }
    }
}