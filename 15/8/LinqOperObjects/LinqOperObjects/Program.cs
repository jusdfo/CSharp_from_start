using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOperObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intScores = { 45, 68, 80, 90, 75, 76, 32 };//定义int类型的一维数组
            //使用LINQ技术从数组中查找及格范围内的分数
            var score = from hgScroe in intScores
                        where hgScroe >= 60
                        orderby hgScroe ascending
                        select hgScroe;
            Console.WriteLine("及格的分数：");
            foreach (var v in score)//循环访问查询结果并显示
            {
                Console.WriteLine(v.ToString());
            }
            Console.ReadLine();
        }
    }
}
