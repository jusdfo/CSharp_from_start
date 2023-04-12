using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test08
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 1981.00m;//声明decimal类型变量num1
            decimal num2 = 1982.00m;//声明decimal类型变量num2
            bool result;//声明bool类型变量result
            //使result等于num1和num2进行相等运算后的返回值
            result = num1 == num2;
            Console.WriteLine(result);//输出运行结果
            Console.ReadLine();

        }
    }
}
