using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test27
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;//给可以为null的类型赋值
            // y = x,如果 x 是 null, 则 y = -1.
            int y = x ?? -1;
            Console.WriteLine("y是{0}", y);
            Console.ReadLine();
        }
    }
}
