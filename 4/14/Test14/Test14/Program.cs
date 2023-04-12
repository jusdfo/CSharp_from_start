using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;//声明int型变量a
            int b = 5;//声明int型变量b
            //声明boolean型变量，用于保存应用逻辑运算符“&&”后的返回值
            bool result = ((a > b) && (a != b));
            //声明boolean型变量，用于保存应用逻辑运算符“||”后的返回值
            bool result2 = ((a > b) || (a != b));
            Console.WriteLine(result);//将变量result输出
            Console.WriteLine(result2);//将变量result2输出
            Console.Read();
        }
    }
}
