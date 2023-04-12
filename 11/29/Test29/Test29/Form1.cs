using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ImageList = imageList1;
            tabPage1.ImageIndex = 0;
            tabPage2.ImageIndex = 0;
            tabControl1.Appearance = TabAppearance.Buttons;
        }
    }
}