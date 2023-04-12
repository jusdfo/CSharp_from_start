using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    class Program
    {
        public static int Add(int x, int y)			//定义一个静态方法Add，返回值为int类型，有两个int类型的参数
        {
            return x + y;
        }
        public double Add(int x, double y)		//重新定义方法Add，它与第一个的返回值类型及参数类型不同
        {
            return x + y;
        }
        public int Add(int x, int y, int z)			//重新定义方法Add，它与第一个的参数个数不同
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();	//实例化类对象
            int x = 3;
            int y = 5;
            int z = 7;
            double y2 = 5.5;
            //根据传入的参数类型及参数个数的不同调用不同的Add重载方法
            Console.WriteLine(x + "+" + y + "=" + Program.Add(x, y));
            Console.WriteLine(x + "+" + y2 + "=" + program.Add(x, y2));
            Console.WriteLine(x + "+" + y + "+" + z + "=" + program.Add(x, y, z));
            Console.Read();
        }

    }
}
