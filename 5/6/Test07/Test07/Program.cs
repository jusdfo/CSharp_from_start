using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrA = "相信自己";//声明字符串StrA
            string StrB = "永不放弃";//声明字符串StrB
            string newstr = String.Format("{0},{1}!!!", StrA, StrB);//格式化字符串
            Console.WriteLine(newstr);//输出结果
            Console.ReadLine();

        }
    }
}
