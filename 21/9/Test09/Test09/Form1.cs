using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test09
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
            Point point1 = new Point(80, 20);							//实例化Point类
            Point point2 = new Point(40, 50); 							//实例化Point类
            Point point3 = new Point(80, 80); 							//实例化Point类
            Point point4 = new Point(160, 80); 							//实例化Point类
            Point point5 = new Point(200, 50); 							//实例化Point类
            Point point6 = new Point(160, 20); 							//实例化Point类
            Point[] myPoints ={ point1, point2, point3, point4, point5, point6 };	//创建Point结构数组
            //调用Graphics对象的DrawPolygon方法绘制一个多边形
            ghs.DrawPolygon(myPen, myPoints);
        }
    }
}