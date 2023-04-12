using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test08
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();		//实例化类对象
            myProgram.LockThread();					//调用锁定线程方法
        }
        void LockThread()
        {
            Monitor.Enter(this);						//锁定当前线程
            Console.WriteLine("锁定线程以实现线程同步");
            Monitor.Exit(this);						//释放当前线程
        }
    }
}
