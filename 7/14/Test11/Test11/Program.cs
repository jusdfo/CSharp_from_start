using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();				//实例化一个ArrayList对象
            list.Add("TM");							//向ArrayList集合中添加元素
            list.Add("C#从入门到精通");
            foreach (string str in list)					//遍历ArrayList集合中的元素并输出
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
