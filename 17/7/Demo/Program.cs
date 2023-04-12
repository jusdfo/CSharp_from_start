using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    delegate void DelOutput(string s);          //自定义委托类型   
    class Program
    {
        static void NamedMethod(string k)       //与委托匹配的命名方法
        {
            Console.WriteLine(k);
        }
        static void Main(string[] args)
        {
            //委托的引用指向匿名方法delegate(string j){}
            DelOutput del = delegate (string j)
            {
                Console.WriteLine(j);
            };
            del.Invoke("匿名方法被调用");//委托对象del调用匿名方法
            //del("匿名方法被调用");//委托也可使用这种方式调用匿名方法
            Console.Write("\n");
            del = NamedMethod;//委托绑定到命名方法NamedMethod
            del("命名方法被调用");//委托对象del调用命名方法
            Console.ReadLine();
        }
    }
}
