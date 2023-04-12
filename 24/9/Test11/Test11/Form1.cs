using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int First_Count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Int32 tLong = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mrsoft", "UserTimes", 0);
                if (tLong < 30)
                {
                    int Times = tLong + 1;
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mrsoft", "UserTimes", Times);
                    MessageBox.Show("这是您第" + Times + "次使用。");
                }
                else
                {
                    MessageBox.Show("试用期以到请重新注册");
                    Application.Exit();
                }
            }
            catch
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mrsoft", "UserTimes", First_Count, RegistryValueKind.DWord);
                MessageBox.Show("感谢您第1次使用本软件");
            }
        }
    }
}