using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TestClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    class Program
    {
        public delegate int MyDelegate(int x, int y);//定义一个委托类型
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            MyDelegate md = tc.Add;//创建委托类型的实例md,并绑定到Add方法
            int intSum = md(2, 3);//委托的调用
            Console.WriteLine("运算结果是：" + intSum.ToString());
            Console.Read();
        }
    }
}
