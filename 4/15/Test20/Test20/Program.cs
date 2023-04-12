using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test20
{
    class Program
    {
        static void Main(string[] args)
        {
            uint intmax = 8;								//声明uint类型变量intmax
            uint bytemask;										//声明uint类型变量bytemask
            bytemask = intmax << 8;								//使intmax左移8次
            Console.WriteLine(bytemask);							//输出结果
            Console.ReadLine();

        }
    }
}
