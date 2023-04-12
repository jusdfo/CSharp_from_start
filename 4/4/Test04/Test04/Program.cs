using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;										//声明整型变量num1，并赋值为10
            int num2 = 20;										//声明整型变量num2，并赋值为20
            int sum;										    //声明整型变量sum
            sum = num1 * num2;									//使sum的值为num1和num2的乘积
            Console.WriteLine(sum.ToString());
            Console.Read();

        }
    }
}
