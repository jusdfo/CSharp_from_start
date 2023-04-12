using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02
{
    class Program
    {
        public static int Add(int x, int y)							//定义一个静态方法
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("结果为：" + Program.Add(3, 5));		//使用类名调用静态方法
            Console.Read();
        }

    }
}
