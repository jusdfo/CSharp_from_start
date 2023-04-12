using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            string stra = "AI时代";								//声明一个字符串变量stra并初始化
            string strb;											//声明一个字符串变量strb
            //使用String类的Copy方法，复制字符串stra并赋值给strb
            strb = String.Copy(stra);
            Console.WriteLine(strb);								//输出字符串strb
            Console.ReadLine();

        }
    }
}
