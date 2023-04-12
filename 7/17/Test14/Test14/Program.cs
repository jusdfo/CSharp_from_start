using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();				//实例化Hashtable对象
            hashtable.Add("id", "BH0001");					//向Hashtable哈希表中添加元素
            hashtable.Add("name", "TM");
            hashtable.Add("sex", "男");
            hashtable.Remove("sex");						//移除Hashtable哈希表中的指定元素
            Console.WriteLine(hashtable.Count);
            Console.Read();
        }
    }
}
