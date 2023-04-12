using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        public int Add(int x, int y)								//定义一个非静态方法
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Program program = new Program();					//实例化类对象
            Console.WriteLine("结果为：" + program.Add(3, 5));		//使用类对象调用定义的非静态方法
            Console.Read();
        }

    }
}
