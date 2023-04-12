using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInfo.Checked == true)
            {
                ckLinfo.Visible = true;

                CheckAll(ckLinfo);
            }
            else
            {
                ckLinfo.Visible = false;
                CheckAllEsce(ckLinfo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radWoman.Checked = false;
            radMan.Checked = false;
            //  VisbCheck(false);
        }

        private void ckShop_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShop.Checked == true)
            {
                cklShop.Visible = true;
                CheckAll(cklShop);
            }
            else
            {
                cklShop.Visible = false;
                CheckAllEsce(cklShop);
            }// end block if 
        }

        private void ckSell_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSell.Checked == true)
            {
                cklSell.Visible = true;
                CheckAll(cklSell);
            }
            else
            {
                cklSell.Visible = false;
                CheckAllEsce(cklSell);
            }// end block if 
        }

        private void ckMange_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMange.Checked == true)
            {
                cklMange.Visible = true;
                CheckAll(cklMange);
            }
            else
            {
                cklMange.Visible = false;
                CheckAllEsce(cklMange);

            }// end block
        }
        //全部选中方法，参数传控件名称name 属性值 
        public void CheckAll(object chckList)
        {
            if (chckList.GetType().ToString() == "System.Windows.Forms.CheckedListBox")
            {
                CheckedListBox ckl = (CheckedListBox)chckList;
                for (int i = 0; i < ckl.Items.Count; i++)
                { ckl.SetItemCheckState(i, CheckState.Checked); }
            }// end block if 
        }//end mehtod block 
        //全部取选中方法，参数传控件名称name 属性值 
        public void CheckAllEsce(object chckList)
        {
            if (chckList.GetType().ToString() == "System.Windows.Forms.CheckedListBox")
            {
                CheckedListBox ckl = (CheckedListBox)chckList;
                for (int i = 0; i < ckl.Items.Count; i++)
                { ckl.SetItemCheckState(i, CheckState.Unchecked); }
            }// end block if 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("用户姓名不能为空", "提示");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("用户密码", "提示");
                    return;
                }
                if (radMan.Checked == false && radWoman.Checked == false)
                {
                    MessageBox.Show("请选择用户性别", "提示");
                    return;
                }
                if (ckInfo.Checked == false && ckMange.Checked == false && ckSell.Checked == false && ckShop.Checked == false)
                {
                    MessageBox.Show("请任选一项用户权限", "提示");
                    return;
                }// end 
                string strName = textBox1.Text.ToString();
                string strPassword = textBox2.Text;
                string strPhon = textBox3.Text;
                string srtEmail = textBox4.Text;
                string strAdress = textBox5.Text;
                string strSex;
                if (radWoman.Checked == true)
                {
                    strSex = "女";
                }
                else
                {
                    strSex = "男";
                }

                string strCkNabge = "库存管理：" + "\n";
                string strCklsell = "销售管理：" + "\n";
                string strCklShop = "进货管理:" + "\n";

                string strCkl = "基本档案:" + "\n";
                if (ckLinfo.Visible == true)
                {

                    for (int i = 0; i < ckLinfo.CheckedItems.Count; i++)
                    {

                        strCkl += ckLinfo.CheckedItems[i].ToString() + "\n";
                    }
                }// end block if 
                if (cklMange.Visible == true)
                {

                    for (int i = 0; i < cklMange.CheckedItems.Count; i++)
                    {
                        strCkNabge += cklMange.CheckedItems[i].ToString() + "\n";
                    }

                }// end block 
                if (cklSell.Visible == true)
                {

                    for (int i = 0; i < cklSell.CheckedItems.Count; i++)
                    {
                        strCklsell += cklSell.CheckedItems[i].ToString() + "\n";
                    }

                }// end block 
                if (cklShop.Visible == true)
                {
                    for (int i = 0; i < cklShop.CheckedItems.Count; i++)
                    {
                        strCklShop += cklShop.CheckedItems[i].ToString() + "\n";

                    }
                }// end blick if 
                MessageBox.Show("注册信息如下：" + "\n" + "姓名:" + strName + "\n" + "密码：" + strPassword + "\n" + "电话:" + strPhon + "\n" + "邮箱:" + srtEmail + "\n" + "地址:" + strAdress + "\n" + "性别：" + strSex + "\n" + "用户权限如下：" + "\n" + strCkl + strCkNabge + strCklsell + strCklShop, "信息确认");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            radWoman.Checked = false;
            radMan.Checked = false;
            ckInfo.Checked = false;
            ckMange.Checked = false;
            ckSell.Checked = false;
            ckShop.Checked = false;
        }
    }
}