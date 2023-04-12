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
            int[,] arr1 = new int[2, 3] { { 1, 3, 5 }, { 2, 4, 6 } };			//定义一个二维数组，并赋值
            //定义两个一维数组，用来存储拆分的二维数组中的元素
            int[] arr2 = new int[3];
            int[] arr3 = new int[3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (i)
                    {
                        case 0: arr2[j] = arr1[i, j]; break;			//判断如果是第一行中的元素，则添加到第一个中
                        case 1: arr3[j] = arr1[i, j]; break;			//判断如果是第二行中的元素，则添加到第二个中
                    }
                }
            }
            Console.WriteLine("数组一：");
            foreach (int n in arr2)								//输出拆分后的第一个一维数组
                Console.Write(n + " ");
            Console.WriteLine();
            Console.WriteLine("数组二：");						//输出拆分后的第二个一维数组
            foreach (int n in arr3)
                Console.Write(n + " ");
            Console.WriteLine();
            Console.Read();
        }
    }
}
