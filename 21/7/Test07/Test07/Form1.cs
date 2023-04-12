using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Graphics ghs = this.CreateGraphics();					//实例化Graphics类
            Pen myPen = new Pen(Color.Black, 3);						//实例化Pen类
            Rectangle myRectangle = new Rectangle(70, 20, 100, 60);		//定义一个Rectangle结构
            //调用Graphics对象的DrawArc方法
            ghs.DrawArc(myPen, myRectangle, 210, 120);
        }
    }
}