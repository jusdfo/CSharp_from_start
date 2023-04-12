using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string userRoot = string.Empty;
        public static string subkey = string.Empty;
        public static string strInfo = string.Empty;
        public static string str = string.Empty, strReader = string.Empty;
        public RegistryKey rkey;
        private void Form1_Load(object sender, EventArgs e)
        {
            Banding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //设默认值 
            string keyName = this.label2.Text.Trim().ToString() + "\\" + this.textBox1.Text.Trim().ToString();
            object obj = (object)this.textBox2.Text.Trim();
            string strName = this.textBox3.Text.Trim().ToString();
            if (strReader != string.Empty)
            {
                switch (strReader)
                {
                    case "one":
                        {
                            Registry.SetValue(keyName, strName, obj, RegistryValueKind.String);
                            break;
                        }
                    case "four":
                        {
                            Registry.SetValue(keyName, strName, obj, RegistryValueKind.ExpandString);
                            break;
                        }

                }
                this.Banding();
            }
            else
            {
                MessageBox.Show("请选择创建方式（例如字符串型）");
            }  
        }

        private void TVRegedit_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                strInfo = this.TVRegedit.SelectedNode.Parent.Text;
            }
            catch
            {
                strInfo = string.Empty;
            }
            str = e.Node.Text;
            if (strInfo != string.Empty)
            {
                this.label2.Text = strInfo + "\\" + str;
            }
            else
            {
                this.label2.Text = str;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                strReader = "one";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
            {
                strReader = "four";
            }
        }
        private void Banding()
        {
            this.TVRegedit.Nodes.Clear();
            RegistryKey rkRoot = Registry.ClassesRoot;
            RegistryKey rkUse = Registry.CurrentUser;
            RegistryKey rkMachine = Registry.LocalMachine;
            RegistryKey rkUsers = Registry.Users;
            RegistryKey rkConfig = Registry.CurrentConfig;

            TreeNode tRoot = new TreeNode("HKEY_CLASSES_ROOT");
            foreach (string si in rkRoot.GetSubKeyNames())
            {
                tRoot.Nodes.Add(si.ToString());
            }

            TreeNode tUse = new TreeNode("HKEY_CURRENT_USER");
            foreach (string si in rkUse.GetSubKeyNames())
            {
                tUse.Nodes.Add(si.ToString());
            }

            TreeNode tMachine = new TreeNode("HKEY_LOCAL_MACHINE");
            foreach (string si in rkMachine.GetSubKeyNames())
            {
                tMachine.Nodes.Add(si.ToString());
            }

            TreeNode tUsers = new TreeNode("HKEY_USERS");
            foreach (string si in rkUsers.GetSubKeyNames())
            {
                tUsers.Nodes.Add(si.ToString());
            }

            TreeNode tConfig = new TreeNode("HKEY_CURRENT_CONFIG");
            foreach (string si in rkConfig.GetSubKeyNames())
            {
                tConfig.Nodes.Add(si.ToString());
            }

            this.TVRegedit.Nodes.Add(tRoot);
            this.TVRegedit.Nodes.Add(tUse);
            this.TVRegedit.Nodes.Add(tMachine);
            this.TVRegedit.Nodes.Add(tUsers);
            this.TVRegedit.Nodes.Add(tConfig);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Banding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey rky = Registry.CurrentConfig.CreateSubKey(this.textBox4.Text.Trim().ToString());
            this.Banding();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = this.label2.Text.Trim().ToString();
            str = str.Substring(str.IndexOf("\\") + 1);
            if (MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Registry.CurrentConfig.DeleteSubKeyTree(str);
                this.Banding();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = this.label2.Text.Trim().ToString();
            string defalutResut;
            if (str.IndexOf("\\") != -1)
            {
                defalutResut = str.Substring(0, str.IndexOf("\\"));
                str = str.Substring(str.IndexOf("\\") + 1);
            }
            else
            {
                defalutResut = str;
            }
            switch (defalutResut)
            {
                case "HKEY_CLASSES_ROOT":
                    {
                        rkey = Registry.ClassesRoot;
                        break;
                    }
                case "HKEY_CURRENT_USER":
                    {
                        rkey = Registry.CurrentUser;
                        break;
                    }
                case "HKEY_LOCAL_MACHINE":
                    {
                        rkey = Registry.LocalMachine;
                        break;
                    }
                case "HKEY_USERS":
                    {
                        rkey = Registry.Users;
                        break;
                    }
                case "HKEY_CURRENT_CONFIG":
                    {
                        rkey = Registry.CurrentConfig;
                        break;
                    }
            }
            try
            {
                RegistryKey rkeyS = rkey.OpenSubKey(str);
                if (rkeyS.ValueCount > 0)
                {
                    foreach (string strValue in rkeyS.GetValueNames())
                    {
                        MessageBox.Show(strValue + "项的值是：" + rkeyS.GetValue(strValue).ToString());
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("无显示值");
                }

            }
            catch
            {
                MessageBox.Show("无显示值");
            }
        }
    }
}