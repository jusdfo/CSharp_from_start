using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FileInfo finfo = new FileInfo(textBox1.Text);         //实例化FileInfo对象
                string strCTime, strLATime, strLWTime, strName, strFName, strDName, strISRead;
                long lgLength;
                strCTime = finfo.CreationTime.ToShortDateString();    //获取文件创建时间
                strLATime = finfo.LastAccessTime.ToShortDateString(); //获取上次访问该文件的时间
                strLWTime = finfo.LastWriteTime.ToShortDateString();  //获取上次写入文件的时间
                strName = finfo.Name;                                 //获取文件名称
                strFName = finfo.FullName;                            //获取文件的完整目录
                strDName = finfo.DirectoryName;                       //获取文件的完整路径
                strISRead = finfo.IsReadOnly.ToString();              //获取文件是否只读
                lgLength = finfo.Length;                              //获取文件长度
                MessageBox.Show("文件信息：\n创建时间：" + strCTime + " 上次访问时间：" + strLATime + "\n上次写入时间：" + strLWTime + " 文件名称：" + strName + "\n完整目录：" + strFName + "\n完整路径：" + strDName + "\n是否只读：" + strISRead + " 文件长度：" + lgLength);
            }
        }
    }
}