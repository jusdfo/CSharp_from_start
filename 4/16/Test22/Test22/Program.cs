using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;											//声明整型变量i
            bool result = i is int;									//判断i是否为整型
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();

        }
    }
}
