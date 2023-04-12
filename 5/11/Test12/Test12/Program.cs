using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "*^__^*";						//声明一个字符串变量str1
            //声明一个字符串变量str2，并使用PadLeft方法在str1的左侧填充字符“(”
            string str2 = str1.PadLeft(7, '(');
            //声明一个字符串变量str3，并使用PadRight方法在str2右侧填充字符“)”
            string str3 = str2.PadRight(8, ')');
            Console.WriteLine("补充字符串之前：" + str1);		//输出字符串str1
            Console.WriteLine("补充字符串之后：" + str3);		//输出字符串str2
            Console.ReadLine();

        }
    }
}
