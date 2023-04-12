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
            string Str1 = "支付宝";					//声明一个字符串Str1 
            string Str2 = "微信支付";					//声明一个字符串Str2
            Console.WriteLine(Str1.Equals(Str2));			//用Equals方法比较字符串Str1和Str2
            Console.WriteLine(String.Equals(Str1, Str2));		//用Equals方法比较字符串Str1和Str2
            Console.ReadLine();

        }
    }
}
