using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 55;										//声明整型变量num1，并赋值为55
            int num2 = 10;										//声明整型变量num2，并赋值为10
            int result;											//声明整型变量result
            result = num1 % num2;									//使result等于num1与num2求余运算之后的值
            Console.WriteLine(result.ToString());
            Console.Read();

        }
    }
}
