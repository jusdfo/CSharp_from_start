using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test09
{
    class Program
    {
        static void ReturnName()
        {
            string name = "人因梦想而伟大";
            Console.WriteLine(name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            try
            {
                ReturnName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
