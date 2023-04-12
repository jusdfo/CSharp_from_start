using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出提示问题
            Console.WriteLine("请输入要查询的录取分数线（比如民办本科、艺术类本科、体育类本科、二本、一本）");
            string strNum = Console.ReadLine();   //获取用户输入的数据
            switch (strNum)
            {
                case "民办本科":                        //查询民办本科分数线
                    Console.WriteLine("民办本科录取分数线：350");
                    break;
                case "艺术类本科":                  //查询艺术类本科分数线
                    Console.WriteLine("艺术类本科录取分数线：290");
                    break;
                case "体育类本科":                   //查询体育类本科分数线
                    Console.WriteLine("体育类本科录取分数线：280");
                    break;
                case "二本":                         //查询二本分数线
                    Console.WriteLine("二本录取分数线：445");
                    break;
                case "一本":                           //查询一本分数线
                    Console.WriteLine("一本录取分数线：555");
                    break;
                default:                                //如果不是以上输入，则输入错误
                    Console.WriteLine("您输入的查询信息有误！");
                    break;
            }
            Console.ReadLine();
        }
    }
}
