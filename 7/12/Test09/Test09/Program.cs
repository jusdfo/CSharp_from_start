using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            ArrayList List = new ArrayList(arr); 		//使用声明的一维数组实例化一个ArrayList对象
            Console.WriteLine("原ArrayList集合：");
            foreach (int i in List)					//遍历ArrayList集合并输出
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                List.Add(i + arr.Length);			//为ArrayList集合添加元素
            }
            Console.WriteLine("使用Add方法添加：");
            foreach (int i in List)					//遍历添加元素后的ArrayList集合并输出
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List.Insert(6, 6);						//在ArrayList集合的指定位置添加元素
            Console.WriteLine("使用Insert方法添加：");
            foreach (int i in List)					//遍历最后的ArrayList集合并输出
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
