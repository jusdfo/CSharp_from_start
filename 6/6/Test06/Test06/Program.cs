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
            int s = 0, num = 80;							//声明两个int类型的变量并初始化
            while (s < num)							//调用while语句，当s小于num时执行
            {
                s++;								//s自增1
                if (s > 40)							//使用if语句判断s是否大于40
                {
                    break;							//使用break语句终止循环
                }
                if ((s % 2) == 0)						//调用if语句判断s是否为偶数
                {
                    continue;						//使用continue语句将程序转到下一次循环
                }
                Console.WriteLine(s);					//输出s
            }
            Console.ReadLine();

        }
    }
}
