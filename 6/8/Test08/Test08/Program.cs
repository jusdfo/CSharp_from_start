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
            int[] myint = new int[10];						//声明一个具有10个元素的整型数组
            myint[0] = 0;								//向数组中添加第一个元素
            myint[1] = 1;								//向数组中添加第二个元素
            myint[2] = 2;								//向数组中添加第三个元素
            myint[3] = 3;								//向数组中添加第四个元素
            myint[4] = 4;								//向数组中添加第五个元素
            myint[5] = 5;								//向数组中添加第六个元素
            myint[6] = 6;								//向数组中添加第七个元素
            myint[7] = 7;								//向数组中添加第八个元素
            myint[8] = 8;								//向数组中添加第九个元素
            myint[9] = 9;								//向数组中添加第十个元素
            for (int i = 0; i < myint.Length; i++)				//调用for循环语句
            {
                Console.WriteLine("myint[{0}]的值是：{1}", i, myint[i]);	//输出结果
            }
            Console.ReadLine();

        }
    }
}
