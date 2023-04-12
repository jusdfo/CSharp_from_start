using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                //打开"SOFTWARE"子键
                RegistryKey software = hklm.OpenSubKey("HARDWARE", true);
                //打开MR子键
                RegistryKey no1 = software.OpenSubKey("MR", true);
                //删除名称为测试的子键
                no1.DeleteSubKey("测试", false);
                MessageBox.Show("删除成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}