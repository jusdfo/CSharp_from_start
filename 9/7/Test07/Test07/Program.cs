using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test07
{
    class Program
    {
        //实例化保存四边形对象的数组对象
        private Program[] qtest = new Program[6];
        private int nextIndex = 0;
        public void draw(Program q)
        { 			
            //定义draw()方法，参数为四边形对象
            if (nextIndex < qtest.Length)
            {
                qtest[nextIndex] = q;
                Console.WriteLine(nextIndex);
                nextIndex++;
            }
        }
        static void Main(string[] args)
        {
            //实例化两个四边形对象，用于调用draw()方法
            Program q = new Program();
            q.draw(new Square()); //以正方形对象为参数调用draw()方法
            //以平行四边形对象为参数调用draw()方法
            q.draw(new Parallelogramgle());
            Console.ReadLine();
        }
    }
    class Square : Program
    { 			
        //定义一个正方形类，继承四边形类
        public Square()
        {
            Console.WriteLine("正方形");
        }
    }
    //定义一个平行四边形类，继承四边形类
    class Parallelogramgle : Program
    {
        public Parallelogramgle()
        {
            Console.WriteLine("平行四边形");
        }
    }
}
