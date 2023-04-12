using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelArrayYes
{
    class Program
    {
        /// <summary>
        /// 删除数组中的元素，并改变数组的长度
        /// </summary>
        /// <param name="ArrayBorn">要从中删除元素的数组</param>
        /// <param name="Index">删除索引</param>
        /// <param name="Len">删除的长度</param>
        /// <returns>得到的新数组</returns>
        static string[] DeleteArray(string[] ArrayBorn, int Index, int Len)
        {
            if (Len <= 0)//判断删除长度是否小于等于0
                return ArrayBorn;//返回源数组
            if (Index == 0 && Len >= ArrayBorn.Length)//判断删除长度是否超出了数组范围
                Len = ArrayBorn.Length;//将删除长度设置为数组的长度
            else if ((Index + Len) >= ArrayBorn.Length)//判断删除索引和长度的和是否超出了数组范围
                Len = ArrayBorn.Length - Index - 1;//设置删除的长度
            string[] temArray = new string[ArrayBorn.Length - Len];//声明一个新的数组
            for (int i = 0; i < temArray.Length; i++)//遍历新数组
            {
                if (i >= Index)//判断遍历索引是否大于等于删除索引
                    temArray[i] = ArrayBorn[i + Len];//为遍历到的索引元素赋值
                else
                    temArray[i] = ArrayBorn[i];//为遍历到的索引元素赋值
            }
            return temArray;//返回得到的新数组
        }

        static void Main(string[] args)
        {
            string[] ArrayStr = new string[] { "m", "r", "s", "o", "f", "t" };//声明一个字符串数组
            Console.WriteLine("源数组：");
            foreach (string i in ArrayStr)//遍历源数组
                Console.Write(i + " ");//输出数组中的元素
            Console.WriteLine();//换行
            string[] newArray = DeleteArray(ArrayStr, 0, 1);//删除数组中的元素
            Console.WriteLine("删除元素后的数组：");
            foreach (string i in newArray)//遍历删除元素后的数组
                Console.Write(i + " ");//输出数组中的元素
            Console.ReadLine();
        }
    }
}
