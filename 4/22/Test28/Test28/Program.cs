using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test28
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = 2.5;
            Console.WriteLine(++x);
            x = 2.5;
            Console.WriteLine(x++);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
