using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输出结果为：");
            for (int i = 1; i <= 8; i++)
            {
                if (i < 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
