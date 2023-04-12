using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace paramsExam
{
    class Program
    {
        static void UseParams(params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main()
        {
            string[] strName = new string[5] { "我", "是", "中", "国", "人" };
            UseParams(strName);
            Console.Read();
        }
    }
}
