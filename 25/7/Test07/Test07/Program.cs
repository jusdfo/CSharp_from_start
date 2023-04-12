using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();			//实例化类对象
            myProgram.LockThread();						//调用锁定线程方法
        }
        void LockThread()
        {
            lock (this)									//锁定当前线程，以实现同步
            {
                Console.WriteLine("锁定线程以实现线程同步");
            }
        }
    }
}
