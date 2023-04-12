using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test08
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;//获取系统当前日期
            string strB = String.Format("{0:D}", dt);//格式化成短日期格式
            Console.WriteLine(strB);//输出日期
            Console.ReadLine();
        }
    }
}
