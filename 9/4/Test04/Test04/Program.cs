using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    class Program
    {
        int i = 47; //定义成员变量
        public void call()//定义成员方法
        {
            Console.WriteLine("调用call()方法");
            for (i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                if (i == 2)
                {
                    Console.WriteLine("\n");
                }
            }
        }
        public Program()//定义构造函数
        {
        }
        static void Main(string[] args)
        {
            Program t1 = new Program();//创建一个对象
            Program t2 = new Program();//创建另一个对象
            t2.i = 60;//将类成员变量赋值为60
            //使用第一个对象调用类成员变量
            Console.WriteLine("第一个实例对象调用变量i的结果：" + t1.i++);
            t1.call();//使用第一个对象调用类成员方法
            //使用第二个对象调用类成员变量
            Console.WriteLine("第二个实例对象调用变量i的结果：" + t2.i);
            t2.call();//使用第二个对象调用类成员方法
            Console.ReadLine();
        }
    }
}
