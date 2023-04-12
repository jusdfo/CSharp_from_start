using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddItem
{
    class Program
    {
        /// <summary>
        /// 增加单个数组元素
        /// </summary>
        /// <param name="ArrayBorn">要向其中添加元素的一维数组</param>
        /// <param name="Index">添加索引</param>
        /// <param name="Value">添加值</param>
        /// <returns></returns>
        static int[] AddArray(int[] ArrayBorn, int Index, int Value)
        {
            if (Index >= (ArrayBorn.Length))//判断添加索引是否大于数组的长度
                Index = ArrayBorn.Length - 1;//将添加索引设置为数组的最大索引
            int[] TemArray = new int[ArrayBorn.Length + 1];//声明一个新的数组
            for (int i = 0; i < TemArray.Length; i++)//遍历新数组的元素
            {
                if (Index >= 0)//判断添加索引是否大于等于0
                {
                    if (i < (Index + 1))//判断遍历到的索引是否小于添加索引加1
                        TemArray[i] = ArrayBorn[i];//交换元素值
                    else if (i == (Index + 1))//判断遍历到的索引是否等于添加索引加1
                        TemArray[i] = Value;//为遍历到的索引设置添加值
                    else
                        TemArray[i] = ArrayBorn[i - 1];//交换元素值
                }
                else
                {
                    if (i == 0)//判断遍历到的索引是否为0
                        TemArray[i] = Value;//为遍历到的索引设置添加值
                    else
                        TemArray[i] = ArrayBorn[i - 1];//交换元素值
                }
            }
            return TemArray;//返回插入元素后的新数组
        }
        static void Main(string[] args)
        {
            int[] ArrayInt = new int[] { 0, 1, 2, 3, 4, 6, 7, 8, 9 };//声明一个一维数组
            Console.WriteLine("原数组元素：");
            foreach (int i in ArrayInt)//遍历声明的一维数组
                Console.Write(i+" ");//输出数组中的元素
            Console.WriteLine();//换行
            ArrayInt = AddArray(ArrayInt, 4, 5);//调用自定义方法向数组中插入单个元素
            Console.WriteLine("插入之后的数组元素：");
            foreach (int i in ArrayInt)//遍历插入元素后的一维数组
                Console.Write(i+" ");//输出数组中的元素
            Console.ReadLine();
        }
    }
}
