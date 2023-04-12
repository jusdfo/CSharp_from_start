using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        partial class account								//分部类第一部分
        {
            public int addition(int a, int b)					//创建一个整型方法
            {
                return a + b;								//方法中的加法运算
            }
        }
        partial class account								//分部类第二部分
        {
            public int multiplication(int a, int b)				//创建一个整型方法
            {
                return a * b;								//方法中的乘法运算
            }
        }
        partial class account  //减法
        {
            public int subtration(int a,int b)
            {
                return a-b; 
            }
        }
        partial class account //除法
        {
            public int division(int a, int b)
            {
                return a / b;
            }
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                account at = new account();
                int M = int.Parse(txtNo1.Text.Trim());
                int N = int.Parse(txtNo2.Text.Trim());
                string str = comboBox1.Text;
                switch (str)
                {
                    case "加": txtResult.Text = at.addition(M, N).ToString(); break;
                    case "减": txtResult.Text = at.subtration(M, N).ToString(); break;
                    case "乘": txtResult.Text = at.multiplication(M, N).ToString(); break;
                    case "除": txtResult.Text = at.division(M, N).ToString(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}