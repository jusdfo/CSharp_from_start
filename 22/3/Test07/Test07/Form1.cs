using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("蝶恋花", new Font("宋体", 15), Brushes.Black, 350, 80);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 185, 720, 185);
            e.Graphics.DrawString("伫倚危楼风细细，望极春愁，黯黯生天际。", new Font("宋体", 12), Brushes.Black, 110, 195);
            e.Graphics.DrawString("草色烟光残照里,无言谁会凭阑意。", new Font("宋体", 12), Brushes.Black, 110, 220);
            e.Graphics.DrawString("拟把疏狂图一醉,对酒当歌，强乐还无味。", new Font("宋体", 12), Brushes.Black, 110, 245);
            e.Graphics.DrawString("衣带渐宽终不悔。为伊消得人憔悴。", new Font("宋体", 12), Brushes.Black, 110, 270);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 300, 720, 300);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要预览打印文档", "打印预览", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.printPreviewDialog1.UseAntiAlias = true;
                //设置要预览的文档
                this.printPreviewDialog1.Document = this.printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                //调用Print方法直接打印文档
                this.printDocument1.Print();
            }
        }
    }
}