using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            //����"��ӡ���ļ�"��ѡ��
            printDialog1.AllowPrintToFile = true;
            //��ʾ����ǰ���ť
            printDialog1.AllowCurrentPage = true;
            //����"ѡ��ť"
            printDialog1.AllowSelection = true;
            //����"ҳ"��ť
            printDialog1.AllowSomePages = true;
            printDialog1.ShowDialog();
        }
    }
}