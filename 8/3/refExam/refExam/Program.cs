using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refExam
{
    class Program
    {
        public static void Method(ref int i)
        {
            i = 44;
        }
        public static void Main()
        {
            int val = 0;
            Method(ref val);
            Console.WriteLine(val);
            Console.Read();
        }
    }
}
