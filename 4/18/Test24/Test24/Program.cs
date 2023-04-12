using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phone = new string[5];							//创建具有5个项目的string类型数组
            phone[0] = "华为P30";									//为数组第一项赋值
            phone[1] = "荣耀V20";									//为数组第二项赋值
            phone[2] = "小米9";									//为数组第三项赋值
            phone[3] = "VIVO X23";									//为数组第四项赋值
            phone[4] = "OPPO R17";									//为数组第五项赋值
            Console.WriteLine(phone[0]);							//输出数组第一项
            Console.WriteLine(phone[1]);							//输出数组第二项
            Console.WriteLine(phone[2]);							//输出数组第三项
            Console.WriteLine(phone[3]);							//输出数组第四项
            Console.WriteLine(phone[4]);							//输出数组第五项
            Console.ReadLine();

        }
    }
}
