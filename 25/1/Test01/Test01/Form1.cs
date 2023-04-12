using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strInfo = string.Empty;                             //定义一个字符串，用来记录线程相关信息
            Thread myThread = new Thread(new ThreadStart(threadOut));  //实例化Thread线程类对象
            myThread.Start();                                          //启动新的线程
            //获取线程相关信息
            strInfo = "线程唯一标识符：" + myThread.ManagedThreadId;
            strInfo += "\n线程名称：" + myThread.Name;
            strInfo += "\n线程状态：" + myThread.ThreadState.ToString();
            strInfo += "\n线程优先级：" + myThread.Priority.ToString();
            strInfo += "\n是否为后台线程：" + myThread.IsBackground;
            Thread.Sleep(1000);                                        //使主线程休眠1秒钟
            myThread.Abort("退出");                                    //通过主线程阻止新开线程
            myThread.Join();                                           //等待新开的线程结束
            MessageBox.Show("线程运行结束");
            richTextBox1.Text = strInfo;
        }
        public void threadOut()
        {
            MessageBox.Show("新线程开始运行");
        }
    }
}