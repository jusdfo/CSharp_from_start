﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1112;//声明整型变量num1
            int num2 = 927;//声明整型变量num2
            bool result;//声明bool型变量result
            //使result等于num1和num2进行小于运算的返回值
            result = num1 < num2;
            Console.WriteLine(result);//输出结果
            Console.ReadLine();

        }
    }
}
