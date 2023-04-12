using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;									//声明整型变量num1，并赋值为45
            int num2 = 5;										//声明整型变量num2，并赋值为5
            int result;											//声明整型变量result
            result = num1 / num2;								//使result的值为num1除以num2得到的值
            Console.WriteLine(result.ToString());
            Console.Read();
        }
    }
}
