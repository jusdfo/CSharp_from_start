using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = (decimal)1112.82;					//声明整型变量num1，并赋值为1112.82
            decimal num2 = (decimal)9270.81;					//声明整型变量num2，并赋值为9270.81
            decimal num3;										//声明整型变量num3
            num3 = num2 - num1;									//num3的值为num2减去num1得到的值
            Console.WriteLine(num3.ToString());
            Console.Read();

        }
    }
}
