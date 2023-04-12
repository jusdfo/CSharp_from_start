using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
