using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddArrays
{
    class Program
    {
        /// <summary>
        /// 向一维数组中添加一个数组
        /// </summary>
        /// <param name="ArrayBorn">源数组</param>
        /// <param name="ArrayAdd">要添加的数组</param>
        /// <param name="Index">添加索引</param>
        /// <returns>新得到的数组</returns>
        static int[] AddArray(int[] ArrayBorn, int[] ArrayAdd, int Index)
        {
            if (Index >= (ArrayBorn.Length))//判断添加索引是否大于数组的长度
                Index = ArrayBorn.Length - 1;//将添加索引设置为数组的最大索引
            int[] TemArray = new int[ArrayBorn.Length + ArrayAdd.Length];//声明一个新的数组
            for (int i = 0; i < TemArray.Length; i++)//遍历新数组的元素
            {
                if (Index >= 0)//判断添加索引是否大于等于0
                {
                    if (i < (Index + 1))//判断遍历到的索引是否小于添加索引加1
                        TemArray[i] = ArrayBorn[i];//交换元素值
                    else if (i == (Index + 1))//判断遍历到的索引是否等于添加索引加1
                    {
                        for (int j = 0; j < ArrayAdd.Length; j++)//遍历要添加的数组
                            TemArray[i + j] = ArrayAdd[j];//为遍历到的索引设置添加值
                        i = i + ArrayAdd.Length - 1;//将遍历索引设置为要添加数组的索引最大值
                    }
                    else
                        TemArray[i] = ArrayBorn[i - ArrayAdd.Length];//交换元素值
                }
                else
                {
                    if (i == 0)//判断遍历到的索引是否为0
                    {
                        for (int j = 0; j < ArrayAdd.Length; j++)//遍历要添加的数组
                            TemArray[i + j] = ArrayAdd[j];//为遍历到的索引设置添加值
                        i = i + ArrayAdd.Length - 1;//将遍历索引设置为要添加数组的索引最大值
                    }
                    else
                        TemArray[i] = ArrayBorn[i - ArrayAdd.Length];//交换元素值
                }
            }
            return TemArray;//返回添加数组后的新数组
        } 
        static void Main(string[] args)
        {
            int[] ArrayInt = new int[] { 0, 1, 2, 3, 8, 9 };//声明一个数组，用来作为源数组
            int[] ArrayInt1 = new int[] { 4, 5, 6, 7 };//声明一个数组，用来作为要添加的数组
            Console.WriteLine("源数组:");
            foreach (int i in ArrayInt)//遍历源数组
                Console.Write(i+" ");//输出源数组元素
            Console.WriteLine();//换行
            Console.WriteLine("要添加的数组:");
            foreach (int i in ArrayInt1)//遍历要添加的数组
                Console.Write(i + " ");//输出要添加的数组中的元素
            Console.WriteLine();//换行
            ArrayInt = AddArray(ArrayInt, ArrayInt1, 3);//向数组中添加数组
            Console.WriteLine("添加后的数组:");
            foreach (int i in ArrayInt)//遍历添加后的数组
                Console.Write(i+" ");//输出添加后的数组中的元素
            Console.ReadLine();
        }
    }
}
