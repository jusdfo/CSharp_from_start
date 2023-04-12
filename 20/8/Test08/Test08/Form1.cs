using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test08
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
                saveFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //使用“另存为”对话框中输入的文件名实例化FileStream对象
                    FileStream myStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    //使用FileStream对象实例化BinaryWriter二进制写入流对象
                    BinaryWriter myWriter = new BinaryWriter(myStream);
                    //以二进制方式向创建的文件中写入内容
                    myWriter.Write(textBox1.Text);
                    //关闭当前二进制写入流
                    myWriter.Close();
                    //关闭当前文件流
                    myStream.Close();
                    textBox1.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //设置打开文件的格式
            openFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = string.Empty;
                //使用“打开”对话框中选择的文件名实例化FileStream对象
                FileStream myStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                //使用FileStream对象实例化BinaryReader二进制写入流对象
                BinaryReader myReader = new BinaryReader(myStream);
                if (myReader.PeekChar() != -1)
                {
                    //以二进制方式读取文件中的内容
                    textBox1.Text = Convert.ToString(myReader.ReadString());
                }
                //关闭当前二进制读取流
                myReader.Close();
                //关闭当前文件流
                myStream.Close();
            }
        }
    }
}