using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("现在互联网主要在线方式：");
            //声明一个string类型的数组，并初始化
            string[] Players = new string[] { "支付宝", "微信支付", "QQ支付", "银联", "京东白条" };
            int i = 0;//声明一个int类型的变量i并初始化为0
            while (i < Players.Length)//调用while语句当i小于数组长度时执行
            {
                //输出数组中的值
                Console.WriteLine(Players[i]);
                i++;//i自增1
            }
            Console.ReadLine();
        }
    }
}
