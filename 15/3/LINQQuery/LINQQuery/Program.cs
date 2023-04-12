using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个字符串数组
            string[] strName = new string[] { "明日科技","C#编程词典","C#从基础到项目实战","C#范例手册" };
            //定义LINQ查询表达式，从数组中查找长度小于7的所有项
            IEnumerable<string> selectQuery =
                from Name in strName
                where Name.Length<7
                select Name;
            //执行LINQ查询，并输出结果
            foreach (string str in selectQuery)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
