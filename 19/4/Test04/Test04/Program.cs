using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass1<int> mclass1 = new myclass1<int>();
            myclass2<int> mclass2 = new myclass2<int>();
            Console.ReadLine();
        }
        class myclass1<T>
        {
            public myclass1()
            {
                Console.WriteLine("这是第一个泛型类");
            }
        }
        class myclass2<T> : myclass1<T>
        {
            public myclass2()
            {
                Console.WriteLine("这是第二个泛型类");
            }
        }
    }
}
