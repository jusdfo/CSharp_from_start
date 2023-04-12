using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();				//实例化Hashtable对象
            hashtable.Add("id", "BH0001");					//向Hashtable哈希表中添加元素
            hashtable.Add("name", "TM");
            hashtable.Add("sex", "男");
            Console.WriteLine(hashtable.Count);				//获得Hashtable哈希表中的元素个数
            Console.Read();
        }
    }
}
