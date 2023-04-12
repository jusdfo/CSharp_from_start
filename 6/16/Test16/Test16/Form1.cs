using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 9;
            if (i % 2 == 0)
                goto Found;
            else
                goto NoFound;
        NoFound:
            MessageBox.Show(i.ToString() + "不是偶数");
            goto finish;//出口点
        Found:
            MessageBox.Show(i.ToString() + "为偶数");
            goto finish; //出口点
        finish:
            Console.Read();
        }
    }
}