using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            RegistryKey regkey = Registry.LocalMachine;
            RegistryKey sys = regkey.OpenSubKey(@"SOFTWARE");
            foreach (string str in sys.GetSubKeyNames())
            {
                this.listBox1.Items.Add("子项名：" + str);
                RegistryKey sikey = sys.OpenSubKey(str);//打开子键
                foreach (string sVName in sikey.GetValueNames())
                {
                    this.listBox1.Items.Add(sVName + sikey.GetValue(sVName));
                }
            }
        }
    }
}