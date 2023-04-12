using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化两个Point类
            Point p1 = new Point(100, 100);
            Point p2 = new Point(150, 150);
            //实例化LinerGradientBrush类，设置其使用黑色和白色进行渐变
            LinearGradientBrush lgb = new LinearGradientBrush(p1, p2, Color.Black, Color.White);
            Graphics ghs = this.CreateGraphics();					//实例化Graphics类
            //设置WrapMode属性指示该LinearGradientBrush的环绕模式
            lgb.WrapMode = WrapMode.TileFlipX;
            ghs.FillRectangle(lgb, 15, 15, 150, 150);					//填充绘制矩形

        }
    }
}