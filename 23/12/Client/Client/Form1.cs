﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//在其他线程中可以调用主窗体控件
        }

        private bool flag = true;//定义一个bool变量，标识是否接收数据
        private UdpClient udp;//创建UdpClient对象
        private Thread thread;//创建线程对象

        private void button1_Click(object sender, EventArgs e)
        {
            udp = new UdpClient(888);//使用端口号实例化UDP连接对象
            flag = true;//标识接收数据
            //创建IPEndPoint对象，用来显示响应主机的标识
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 888);
            thread = new Thread(() =>//新开线程，执行接收数据操作
            {
                while (flag)//如果标识为true
                {
                    try
                    {
                        if (udp.Available <= 0) continue;//判断是否有网络数据
                        if (udp.Client == null) return;//判断连接是否为空
                        //调用UdpClient对象的Receive方法获得从远程主机返回的UDP数据报
                        byte[] bytes = udp.Receive(ref ipendpoint);
                        //将获得的UDP数据报转换为字符串形式
                        string str = Encoding.Default.GetString(bytes);
                        textBox2.Text = "正在接收的信息：\n" + str;//显示正在接收的数据
                        textBox1.Text += "\n" + str;//显示接收的所有数据
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);//错误提示
                    }
                    Thread.Sleep(1000);//线程休眠1秒
                }
            });
            thread.Start();//启动线程
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;//不接收数据
            if (thread.ThreadState == ThreadState.Running)//判断线程是否运行
                thread.Abort();//终止线程
            udp.Close();//关闭连接
        }
    }
}