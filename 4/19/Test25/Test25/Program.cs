using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test25
{
    class Program
    {
        static void Main(string[] args)
        {
            Type mytype = typeof(string);								//获取引用类型的信息
            Console.WriteLine("类型：{0}", mytype);					//输出结果
            Console.ReadLine();

        }
    }
}
