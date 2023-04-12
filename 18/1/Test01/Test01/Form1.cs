using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Family : System.Collections.IEnumerable
        {
            string[] MyFamily ={ "父亲","母亲","弟弟","妹妹"};
            public System.Collections.IEnumerator GetEnumerator()
            {
                for (int i = 0; i < MyFamily.Length; i++)
                {
                    yield return MyFamily[i];
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Family myfamily = new Family();
            foreach (string str in myfamily)
            {
                richTextBox1.Text += str + "\n";
            }
        }
    }
}