using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrayList List = new ArrayList(arr);			//使用声明的一维数组实例化一个ArrayList对象
            Console.WriteLine("原ArrayList集合：");
            foreach (int i in List)						//遍历ArrayList集合中的元素并输出
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            List.RemoveRange(0, 5);					//从ArrayList集合中移除指定下标位置的元素
            Console.WriteLine("删除元素后的ArrayList集合：");
            foreach (int i in List)						//遍历删除元素后的ArrayList集合并输出其元素
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
