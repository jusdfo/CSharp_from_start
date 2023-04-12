using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test17
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "one world,one dream";				//声明一个字符串变量a并初始化
            //使用Replace方法将字符串a中的“,”替换为“*”，并赋值给字符串变量b
            string b = a.Replace(',', '*');
            Console.WriteLine(b);						//输出字符串变量b
            //使用Replace方法将字符串a中的“one world”替换为“One World”
            string c = a.Replace("one world", "One World");
            Console.WriteLine(c);						//输出字符串变量c
            Console.ReadLine();

        }
    }
}
