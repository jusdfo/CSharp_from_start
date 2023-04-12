using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Thread1));   //使用自定义方法Thread1声明线程
            thread1.Priority = ThreadPriority.Lowest;              //设置线程的调度优先级
            Thread thread2 = new Thread(new ThreadStart(Thread2)); //使用自定义方法Thread2声明线程
            thread1.Start();                                       //开启线程一
            thread2.Start();                                       //开启线程二
            Console.Read();
        }
        static void Thread1()
        {
            Console.WriteLine("线程一");
        }
        static void Thread2()
        {
            Console.WriteLine("线程二");
        }
    }
}
