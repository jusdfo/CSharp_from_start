﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 18;//声明一个int类型的常量i，值为18
            const int j = 30;//声明一个int类型的常量j，值为30
            const int k = 50;//声明一个int类型的常量k，值为50
            int YouAge = 0;//声明一个int类型的变量YouAge，值为0
            Console.WriteLine("请输入您的年龄：");
            YouAge = int.Parse(Console.ReadLine());//获取用户输入的数据
            if (YouAge <= i)//调用if语句判断输入的数据是否小于等于18
            {
                //如果小于等于18则输出提示信息
                Console.WriteLine("您的年龄还小，要努力奋斗哦！");
            }
            else if (YouAge > i && YouAge <= j)//判断是否大于18岁小于30岁
            {
                //如果输入的年龄大于18岁并且小于30岁则输出提示信息
                Console.WriteLine("您现在的阶段正是努力奋斗的黄金阶段！");
            }
            else if (YouAge > j && YouAge <= k)//判断输入的年龄是否大于30岁小于等于50岁
            {
                //如果输入的年龄大于30岁而小于等于50岁则输出提示信息
                Console.WriteLine("您现在的阶段正是人生的黄金阶段！");
            }
            else
            {
                Console.WriteLine("最美不过夕阳红！");
            }
            Console.ReadLine();
        }
    }
}
