using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[3] { "世界杯", "欧洲杯", "欧冠" };//声明一个string数组并初始化
            int i = 0;
            do//调用do…while语句
            {
                Console.WriteLine(myArray[i]);//输出数组中数据
                i++;
            } while (i < myArray.Length);//设置do…while语句的条件
            Console.ReadLine();
        }
    }
}
