using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrA = "AI时代已经到来，你还在等什么";							//声明字符串StrA
            char[] separator = { '，' };								//声明分割字符的数组
            String[] splitstrings = new String[100];						//声明一个字符串数组
            splitstrings = StrA.Split(separator);							//分割字符串
            for (int i = 0; i < splitstrings.Length; i++)
            {
                Console.WriteLine("item{0}:{1}", i, splitstrings[i]);
            }
            Console.ReadLine();

        }
    }
}
