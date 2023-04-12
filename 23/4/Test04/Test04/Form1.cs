using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

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
            richTextBox1.Text = string.Empty;
            WebClient wclient = new WebClient();　　　　　　　//实例化WebClient类对象
            wclient.BaseAddress = textBox1.Text;　　　　　　　//设置WebClient的基URI
            wclient.Encoding = Encoding.UTF8;                 //指定下载字符串的编码方式
            //为WebClient类对象添加标头
            wclient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //使用OpenRead方法获取指定网站的数据，并保存到Stream流中
            Stream stream = wclient.OpenRead(textBox1.Text);
            //使用流Stream声明一个流读取变量sreader
            StreamReader sreader = new StreamReader(stream);
            string str = string.Empty;//声明一个变量，用来保存一行从WebCliecnt下载的数据
            //循环读取从指定网站获得的数据
            while ((str = sreader.ReadLine()) != null)
            {
                richTextBox1.Text += str + "\n";
            }
            //调用WebClient对象的DownloadFile方法将指定网站的内容保存到文件中
            wclient.DownloadFile(textBox1.Text, DateTime.Now.ToFileTime() + ".txt");
            MessageBox.Show("保存到文件成功");
        }
    }
}