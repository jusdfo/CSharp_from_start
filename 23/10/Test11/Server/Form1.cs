using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();                    //隐藏当前窗体
            class1.StartListener(); 　　　　//调用公共类中的方法接收信息
        }
    }
}