using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Test05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            //实例化一个WebRequest对象
            WebRequest webrequest = WebRequest.Create(textBox1.Text);
            //设置用于对Internet资源请求进行身份验证的网络凭据
            webrequest.Credentials = CredentialCache.DefaultCredentials;
            //调用WebRequest对象的各种属性获取WebRequest请求的相关信息
            richTextBox1.Text = "请求数据的内容长度：" + webrequest.ContentLength;
            richTextBox1.Text += "\n该请求的协议方法：" + webrequest.Method;
            richTextBox1.Text += "\n访问Internet的网络代理：" + webrequest.Proxy;
            richTextBox1.Text += "\n与该请求关联的Internet URI：" + webrequest.RequestUri;
            richTextBox1.Text += "\n超时时间：" + webrequest.Timeout;
            //调用WebRequest对象的GetResponse方法实例化一个WebResponse对象
            WebResponse webresponse = webrequest.GetResponse();
            //获取WebResponse响应的Internet资源的URI
            richTextBox1.Text += "\n响应该请求的Internet URI：" + webresponse.ResponseUri;
            //调用WebResponse对象的GetResponseStream方法返回数据流
            Stream stream = webresponse.GetResponseStream();
            //使用创建的Stream对象创建一个StreamReader流读取对象
            StreamReader sreader = new StreamReader(stream);
            //读取流中的内容，并显示在RichTextBox控件中
            richTextBox1.Text += "\n" + sreader.ReadToEnd();
            sreader.Close();
            stream.Close();
            webresponse.Close();
        }
    }
}