using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1000;//声明一个int类型变量Num并初始化为1000
            //实例化一个StringBuilder类，并初始化为“荣耀自称科技标杆”
            StringBuilder honorvsxiaomi = new StringBuilder("荣耀自称科技标杆", 100);
            //使用Append方法将字符串追加到honorvsxiaomi的末尾
            honorvsxiaomi.Append("VS小米死磕高性价比");
            Console.WriteLine(honorvsxiaomi);//输出honorvsxiaomi
            //使用AppendFormat方法将字符串按照指定的格式追加到honorvsxiaomi的末尾
            honorvsxiaomi.AppendFormat("{0:C}", Num);
            Console.WriteLine(honorvsxiaomi);
            //使用Insert方法将“PK：”追加到honorvsxiaomi的开头
            honorvsxiaomi.Insert(0, "PK：");
            Console.WriteLine(honorvsxiaomi);
            //使用Remove方法从honorvsxiaomi中删除索引15以后的字符串
            honorvsxiaomi.Remove(21, honorvsxiaomi.Length - 21);
            Console.WriteLine(honorvsxiaomi);
            //使用Replace方法将“PK：”替换成“相爱相杀”
            honorvsxiaomi.Replace("PK", "相爱相杀");
            Console.WriteLine(honorvsxiaomi);
            Console.ReadLine();
        }
    }
}
