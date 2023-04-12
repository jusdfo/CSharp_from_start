using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int i = 0;
        public static int LastNum;
        private void Form1_Load(object sender, EventArgs e)
        {
            ClsDB.ClsDBControl CDBLast = new Test13.ClsDB.ClsDBControl();
            LastNum = CDBLast.Max();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            ClsDB.ClsDBControl cdb = new Test13.ClsDB.ClsDBControl();
            DataSet dsNew = cdb.dsResult(i);
            this.textBox1.Text = dsNew.Tables[0].Rows[0][0].ToString();
            this.textBox2.Text = dsNew.Tables[0].Rows[0][1].ToString();
            this.textBox3.Text = dsNew.Tables[0].Rows[0][2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i -= 1;
            if (i >= 0)
            {
                ClsDB.ClsDBControl cdb = new Test13.ClsDB.ClsDBControl();
                DataSet dsNew = cdb.dsResult(i);
                this.textBox1.Text = dsNew.Tables[0].Rows[0][0].ToString();
                this.textBox2.Text = dsNew.Tables[0].Rows[0][1].ToString();
                this.textBox3.Text = dsNew.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                i += 1;
                MessageBox.Show("这已是第一条信息");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i <= (LastNum - 1))
            {
                ClsDB.ClsDBControl cdb = new Test13.ClsDB.ClsDBControl();
                DataSet dsNew = cdb.dsResult(i);
                this.textBox1.Text = dsNew.Tables[0].Rows[0][0].ToString();
                this.textBox2.Text = dsNew.Tables[0].Rows[0][1].ToString();
                this.textBox3.Text = dsNew.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                i -= 1;
                MessageBox.Show("这已是最后一条信息");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsDB.ClsDBControl cdb = new Test13.ClsDB.ClsDBControl();
            DataSet dsNew = cdb.dsResult(LastNum - 1);
            this.textBox1.Text = dsNew.Tables[0].Rows[0][0].ToString();
            this.textBox2.Text = dsNew.Tables[0].Rows[0][1].ToString();
            this.textBox3.Text = dsNew.Tables[0].Rows[0][2].ToString();
            i = LastNum - 1;
        }
    }
}