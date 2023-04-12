using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';										//声明字符a
            char b = '8';										//声明字符b
            char c = 'L';										//声明字符c
            char d = '.';										//声明字符d
            char e = '|';										//声明字符e
            char f = ' ';										//声明字符f
            //使用IsLetter方法判断a是否为字母
            Console.WriteLine("IsLetter方法判断a是否为字母：{0}", Char.IsLetter(a));
            //使用IsDigit方法判断b是否为数字
            Console.WriteLine("IsDigit方法判断b是否为数字：{0}", Char.IsDigit(b));
            //使用IsLetterOrDigit方法判断c是否为字母或数字
            Console.WriteLine("IsLetterOrDigit方法判断c是否为字母或数字：{0}", Char.IsLetterOrDigit(c));
            //使用IsLower方法判断a是否为小写字母
            Console.WriteLine("IsLower方法判断a是否为小写字母：{0}", Char.IsLower(a));
            //使用IsUpper方法判断c是否为大写字母
            Console.WriteLine("IsUpper方法判断c是否为大写字母：{0}", Char.IsUpper(c));
            //使用IsPunctuation方法判断d是否为标点符号
            Console.WriteLine("IsPunctuation方法判断d是否为标点符号：{0}", Char.IsPunctuation(d));
            //使用IsSeparator方法判断e是否为分隔符
            Console.WriteLine("IsSeparator方法判断e是否为分隔符：{0}", Char.IsSeparator(e));
            //使用IsWhiteSpace方法判断f是否为空白
            Console.WriteLine("IsWhiteSpace方法判断f是否为空白：{0}", Char.IsWhiteSpace(f));
            Console.ReadLine();

        }
    }
}
