using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test09
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
            Mutex myMutex = new Mutex(false);				//实例化Mutex类对象
            myMutex.WaitOne();							//阻止当前线程
            Console.WriteLine("锁定线程以实现线程同步");
            myMutex.ReleaseMutex();						//释放Mutex对象
        }
    }
}
