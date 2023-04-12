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
            int[] arr = new int[] { 63, 4, 24, 1, 3, 15 };		//定义一个一维数组，并赋值
            int min;									//定义一个int变量，用来存储数组下标
            for (int i = 0; i < arr.Length - 1; i++)				//循环访问数组中的元素值（除最后一个）
            {
                min = i;								//为定义的数组下标赋值
                for (int j = i + 1; j < arr.Length; j++)			//循环访问数组中的元素值（除第一个）
                {
                    if (arr[j] < arr[min])					//判断相邻两个元素值的大小
                        min = j;
                }
                int t = arr[min];							//定义一个int变量，用来存储比较大的数组元素值
                arr[min] = arr[i];							//将小的数组元素值移动到前一位
                arr[i] = t;								//将int变量中存储的较大的数组元素值向后移
            }
            Console.WriteLine("排序后结果为：");
            foreach (int n in arr)							//循环访问排序后的数组元素并输出
                Console.Write("{0}", n + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
