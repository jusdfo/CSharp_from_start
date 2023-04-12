using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rgK = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                rgK.SetValue("HungAppTimeout", 400);
                rgK.SetValue("WaitToKillAppTimeout", 1000);

                Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control", "HungAppTimeout", 400);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control", "WaitToKillServiceTimeout", 1000);
                MessageBox.Show("修改成功--请重新启动计算机");
            }
            catch (Exception ey)
            {
                MessageBox.Show("这个程序可以不适合您的操作系统");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rgK = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Update");
                rgK.SetValue("UpdateMode", 0);//可以弄大些可以看出效果
                MessageBox.Show("修改成功--请重新启动计算机");
            }
            catch (Exception ey)
            {
                MessageBox.Show("这个程序可以不适合您的操作系统");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rgK = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                rgK.SetValue("MenuShowDelay", 0);//可以弄大些可以看出效果
                MessageBox.Show("修改成功--请重新启动计算机");
            }
            catch (Exception ey)
            {
                MessageBox.Show("这个程序可以不适合您的操作系统");
            }
        }
    }
}