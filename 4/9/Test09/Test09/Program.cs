﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 1981.00m;								//声明decimal类型变量num1
            decimal num2 = 1982.00m;								//声明decimal类型变量num2
            bool result;											//声明bool类型变量result
            bool result1;										//声明bool类型变量result1
            result = num1 != num2;									//获取不等运算返回值第一种方法
            result1 = !(num1 == num2);									//获取不等运算返回值第二种方法
            Console.WriteLine(result);								//输出结果
            Console.WriteLine(result1);								//输出结果
            Console.ReadLine();
        }
    }
}
