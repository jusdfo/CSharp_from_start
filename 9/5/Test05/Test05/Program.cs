using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test05
{
    /// <summary>
    /// 自定义类，封装加数和被加数属性
    /// </summary>
    class MyClass
    {
        private int x = 0;						//定义int型变量，作为加数
        private int y = 0;						//定义int型变量，作为被加数
        /// <summary>
        /// 加数
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// 被加数
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <returns>加法运算和</returns>
        public int Add()
        {
            return X + Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();	//实例化MyClass的对象
            myclass.X = 3;					//为MyClass类中的属性赋值
            myclass.Y = 5;					//为MyClass类中的属性赋值
            Console.WriteLine(myclass.Add());	//调用MyClass类中的Add方法求和
            Console.ReadLine();
        }
    }

}
