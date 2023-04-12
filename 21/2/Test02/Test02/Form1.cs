using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics ghs = this.CreateGraphics();					//创建Graphics对象
            for (int i = 1; i < 6; i++)								//使用for循环
            {
                HatchStyle hs = (HatchStyle)(5 + i);					//设置HatchStyle值
                HatchBrush hb = new HatchBrush(hs, Color.White);		//实例化HatchBrush类
                Rectangle rtl = new Rectangle(10, 50 * i, 50 * i, 50);			//根据i值绘制矩形
                ghs.FillRectangle(hb, rtl);							//填充矩形
            }

        }
    }
}