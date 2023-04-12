using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();			//实例化Hashtable对象
            hashtable.Add("id", "BH0001");				//向Hashtable哈希表中添加元素
            hashtable.Add("name", "TM");
            hashtable.Add("sex", "男");
            Console.WriteLine("\t 键\t 值");
            //遍历Hashtable哈希表中的元素并输出其键值对
            foreach (DictionaryEntry dicEntry in hashtable)
            {
                Console.WriteLine("\t " + dicEntry.Key + "\t " + dicEntry.Value);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
