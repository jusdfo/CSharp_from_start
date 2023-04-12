using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1();
        System.Diagnostics.Process myProcess;
        private void Form1_Load(object sender, EventArgs e)
        {
            myProcess = System.Diagnostics.Process.Start("Server.exe");//开启服务
        }
        //“发送”按钮事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(class1.Send(txtServer.Text, txtInfo.Text));//发送信息
            txtInfo.Text = string.Empty;
            txtInfo.Focus();
        }
        //当在“聊天服务器”文本框中输入内容，按下回车键时，将鼠标焦点移动到“信息”文本框中
        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtInfo.Focus();
        }
        //当在“信息”文本框中输入内容，按下回车键时，将鼠标焦点移动到“发送”按钮上
        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSend.Focus();
        }
        //窗体关闭事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcess.Kill();                                         //关闭服务
        }
    }
}