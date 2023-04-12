using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个年份：");					//屏幕输入提示字符串
            string str = Console.ReadLine();						//获取用户输入的年份
            int year = Int32.Parse(str);							//将输入的年份转换成int类型
            //计算输入的年份是否为闰年
            bool isleapyear = ((year % 400) == 0) || (((year % 4) == 0) && ((year % 100) != 0));
            //利用条件运算符输入“是”或者“不是”
            string yesno = isleapyear ? "是" : "不是";
            Console.WriteLine("{0}年{1}闰年", year, yesno);			//输出结果
            Console.ReadLine();
        }
    }
}
