using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelArrayNo
{
    class Program
    {
        /// <summary>
        /// 删除数组中的元素
        /// </summary>
        /// <param name="ArrayBorn">要从中删除元素的数组</param>
        /// <param name="Index">删除索引</param>
        /// <param name="Len">删除的长度</param>
        static void DeleteArray(string[] ArrayBorn, int Index, int Len)
        {
            if (Len <= 0)//判断删除长度是否小于等于0
                return;//返回
            if (Index == 0 && Len >= ArrayBorn.Length)//判断删除长度是否超出了数组范围
                Len = ArrayBorn.Length;//将删除长度设置为数组的长度
            else if ((Index + Len) >= ArrayBorn.Length)//判断删除索引和长度的和是否超出了数组范围
                Len = ArrayBorn.Length - Index - 1;//设置删除的长度
            int i = 0;//定义一个int变量，用来标识开始遍历的位置
            for (i = 0; i < ArrayBorn.Length - Index - Len; i++)//遍历删除的长度
                ArrayBorn[i + Index] = ArrayBorn[i + Len + Index];//覆盖要删除的值
            //遍历删除长度后面的数组元素值
            for (int j = (ArrayBorn.Length - 1); j > (ArrayBorn.Length - Len - 1); j--)
                ArrayBorn[j] = null;//设置数组为空
        }
        static void Main(string[] args)
        {
            string[] ArrayStr = new string[] { "m", "r", "s", "o", "f", "t" };//声明一个字符串数组
            Console.WriteLine("源数组：");
            foreach (string i in ArrayStr)//遍历源数组
                Console.Write(i+" ");//输出数组中的元素
            Console.WriteLine();//换行
            DeleteArray(ArrayStr, 0, 1);//删除数组中的元素
            Console.WriteLine("删除元素后的数组：");
            foreach (string i in ArrayStr)//遍历删除元素后的数组
                Console.Write(i+" ");//输出数组中的元素
            Console.ReadLine();
        }
    }
}
