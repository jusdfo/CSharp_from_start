using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey regkey = Registry.LocalMachine;
            RegistryKey sys = regkey.OpenSubKey(@"SOFTWARE");
            foreach (string str in sys.GetSubKeyNames())
            {
                richTextBox1.Text += str + "\n";
            }
        }
    }
}