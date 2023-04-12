using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("要写入的文件内容不能为空");
            }
            else
            {
                //设置保存文件的格式
                saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //使用“另存为”对话框中输入的文件名实例化StreamWriter对象
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                    //向创建的文件中写入内容
                    sw.WriteLine(textBox1.Text);
                    //关闭当前文件写入流
                    sw.Close();
                    textBox1.Text = string.Empty;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //设置打开文件的格式
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = string.Empty;
                //使用“打开”对话框中选择的文件实例化StreamReader对象
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //调用ReadToEnd方法读取选中文件的全部内容
                textBox1.Text = sr.ReadToEnd();
                //关闭当前文件读取流
                sr.Close();
            }
        }
    }
}