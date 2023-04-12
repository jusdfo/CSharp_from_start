using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Graphics graphics = this.CreateGraphics();					//声明一个Graphics对象
            Pen myPen = new Pen(Color.Black, 8);						//实例化Pen类
            //调用Graphics对象的DrawRectangle方法
            graphics.DrawRectangle(myPen, 10, 10, 150, 100);
        }
    }
}