using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "梦想还是要有的，万一实现了呢！";			//声明字符串变量str1并赋值
            string str2;							//声明字符串变量str2
            str2 = str1.Insert(0, "马云说：");		//使用Insert方法向字符串str1中插入字符串
            string str3 = str2.Insert(19, "你信吗");		//使用Insert方法向字符串str2中插入字符串
            Console.WriteLine(str3);				//输出字符串变量str3
            Console.ReadLine();
        }
    }
}
