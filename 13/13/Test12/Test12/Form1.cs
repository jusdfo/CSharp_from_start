using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim().ToString() != "")
            {
                ClsDB.ClsDBControl DBC = new Test12.ClsDB.ClsDBControl();
                string strSql = "update tb_people set tb_psex='" + this.textBox3.Text.Trim().ToString() + "',tb_pname= '" + this.textBox2.Text.Trim().ToString() + "'  where tb_PID='" + this.textBox1.Text.Trim().ToString() + "'";
                if (DBC.updateDB(strSql))
                {
                    MessageBox.Show("OK");
                }
            }
            else
            {
                MessageBox.Show("请写入编号信息");
            }
        }
    }
}