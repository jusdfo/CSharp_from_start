using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 927;									//声明整型变量num1，并赋值为927
            int num2;										//声明整型变量num2
            num2 = num1 + num1;								//num2的值为num1与num1相加之后的值
            Console.WriteLine(num2.ToString());
            Console.Read();

        }
    }
}
