﻿using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.CalendarDimensions = new Size(2, 2);
        }
    }
}