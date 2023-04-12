using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test07
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
                //打开"HARDWARE"子键
                RegistryKey software = hklm.OpenSubKey("HARDWARE", true);
                //打开MR子键
                RegistryKey no1 = software.OpenSubKey("MR", true);
                //打开测试子键
                RegistryKey no2 = no1.OpenSubKey("测试", true);
                //删除名称为"value"的键值
                no2.DeleteValue("value");
                MessageBox.Show("删除键值成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}