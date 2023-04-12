using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            try									//使用try…catch语句
            {
                checked								//使用checked关键字
                {
                    int Inum1;						//声明一个int类型变量Inum1
                    int Inum2;						//声明一个int类型变量Inum2
                    int Num;							//声明一个int类型变量Num
                    Inum1 = 6000000;					//将Inum1赋值为6000000
                    Inum2 = 6000000;					//将Inum2赋值为6000000
                    Num = Inum1 * Inum2;				//使Num的值等于Inum1与Inum2的乘积
                }
            }
            catch (OverflowException)					//捕获异常
            {
                Console.WriteLine("引发OverflowException异常");
            }
            Console.ReadLine();

        }
    }
}
