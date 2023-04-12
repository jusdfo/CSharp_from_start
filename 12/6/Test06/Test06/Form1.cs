﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(37, 36);
            imageList1.Images.Add(Image.FromFile("01.png"));
            imageList1.Images.Add(Image.FromFile("02.png"));
            listView1.SmallImageList = imageList1;
            listView1.Items.Add("支付宝");
            listView1.Items.Add("微信支付");
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
        }
    }
}