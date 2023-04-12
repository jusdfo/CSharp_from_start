using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                //实例化DirectoryInfo对象
                DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text);
                //获取指定目录下的所有子目录及文件类型
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    if (fsinfo is DirectoryInfo)    //判断是否文件夹
                    {
                        //使用获取的文件夹名称实例化DirectoryInfo对象
                        DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                        //为ListView控件添加文件夹信息
                        listView1.Items.Add(dirinfo.Name);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        //listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        //使用获取的文件名称实例化FileInfo对象
                        FileInfo finfo = new FileInfo(fsinfo.FullName);
                        //为ListView控件添加文件信息
                        listView1.Items.Add(finfo.Name);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.FullName);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}