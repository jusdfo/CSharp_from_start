using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = ".NET也开源了！";	//声明一个字符串变量str1，并初始化
            //声明一个字符串变量str2，并使用Remove方法从字符串str1的索引0处开始删除4个字符
            string str2 = str1.Remove(0, 4);
            Console.WriteLine(str2);						//输出字符串str2
            Console.ReadLine();

        }
    }
}
