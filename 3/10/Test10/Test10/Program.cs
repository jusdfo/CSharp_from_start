using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test10
{
    class Program
    {
        const int i = 2019;
        static void Main(string[] args)
        {
            try
            {
                i = 2020;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
