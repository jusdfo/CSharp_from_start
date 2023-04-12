using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 20;
            numericUpDown1.Minimum = 1;
            numericUpDown1.DecimalPlaces = 2;
        }
    }
}