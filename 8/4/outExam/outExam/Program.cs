using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace outExam
{
    class Program
    {
        public static void Method(out int i)
        {
            i = 44;
        }
        public static void Main()
        {
            int value;
            Method(out value);
            Console.WriteLine("输出参数："+value);
            Console.Read();
        }
    }
}
