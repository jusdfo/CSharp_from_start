using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 927;											//声明一个int类型的变量i并初始化为927
            int j = 112;											//声明一个int类型的变量j并初始化为112
            Console.WriteLine(Math.Sin(i * i + j * j));						//表达式作为参数输出
            Console.ReadLine();

        }
    }
}
