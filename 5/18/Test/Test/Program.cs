﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = ""; //创建空字符串
            //定义对字符串执行操作的起始时间
            long starTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            { //利用for循环执行10000次操作
                str = str + i; //循环追加字符串
            }
            long endTime = DateTime.Now.Millisecond; //定义对字符串操作后的时间
            long time = endTime - starTime; //计算对字符串执行操作的时间
            Console.WriteLine("String消耗时间：" + time); //将执行的时间输出
            StringBuilder builder = new StringBuilder("");//创建字符串生成器
            starTime = DateTime.Now.Millisecond; //定义操作执行前的时间
            for (int j = 0; j < 10000; j++)
            { //利用for循环进行操作
                builder.Append(j); //循环追加字符
            }
            endTime = System.DateTime.Now.Millisecond; //定义操作后的时间
            time = endTime - starTime;//追加操作执行的时间
            Console.WriteLine("StringBuilder消耗时间：" + time); //将操作时间输出
            Console.ReadLine();
        }
    }
}
