﻿using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.ShowWeekNumbers = true;
        }
    }
}