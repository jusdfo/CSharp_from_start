using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int i = 1;
            switch (i)
            {
                default:
                    MessageBox.Show("1到5之外的数");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    MessageBox.Show("1到5之间的数");
                    break;
            }
        }
    }
}