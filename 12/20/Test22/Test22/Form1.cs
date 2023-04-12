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
            string strPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strPath += @"\helpPage.htm";
            helpProvider1.HelpNamespace = strPath;
            MessageBox.Show(strPath);
            helpProvider1.SetShowHelp(this,true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}