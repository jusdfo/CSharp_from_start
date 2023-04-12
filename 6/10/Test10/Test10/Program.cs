using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(DateTime.Today.DayOfWeek);		//获取当前日期的数值
            switch (i)										//调用switch语句
            {
                case 1: Console.WriteLine("今天是星期一"); break;		//如果i是1，则输出今天是星期一
                case 2: Console.WriteLine("今天是星期二"); break;		//如果i是2，则输出今天是星期二
                case 3: Console.WriteLine("今天是星期三"); break;		//如果i是3，则输出今天是星期三
                case 4: Console.WriteLine("今天是星期四"); break;		//如果i是4，则输出今天是星期四
                case 5: Console.WriteLine("今天是星期五"); break;		//如果i是5，则输出今天是星期五
                case 6: Console.WriteLine("今天是星期六"); break;		//如果i是6，则输出今天是星期六
                case 0: Console.WriteLine("今天是星期日"); break;		//如果i是7，则输出今天是星期日
            }
            Console.ReadLine();

        }
    }
}
