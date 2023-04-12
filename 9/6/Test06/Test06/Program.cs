using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test06
{
    /// <summary>
    /// 自定义类
    /// </summary>
    class MyClass1
    {
        private int x = 0;							//定义int型变量，作为加数
        private int y = 0;							//定义int型变量，作为被加数
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
        public int Add1()
        {
            return X + Y;
        }
    }
    /// <summary>
    /// 自定义类，该类继承自MyClass1
    /// </summary>
    class MyClass2 : MyClass1
    {
        private int z = 0;							//定义int型变量，作为第二个被加数
        /// <summary>
        /// 被加数
        /// </summary>
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <returns>加法运算和</returns>
        public int Add2()
        {
            return X + Y + Z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();		//实例化MyClass1的对象
            MyClass2 myclass2 = new MyClass2();		//实例化MyClass2的对象
            myclass1.X = 3;						//为MyClass1类中的属性赋值
            myclass1.Y = 5;						//为MyClass1类中的属性赋值
            myclass2.X = 3;						//使用MyClass2类对象调用基类中的属性并赋值
            myclass2.Y = 5;						//使用MyClass2类对象调用基类中的属性并赋值
            myclass2.Z = 7;						//为MyClass2类中的属性赋值
            Console.WriteLine(myclass1.Add1());		//调用MyClass1类中的Add1方法求和
            Console.WriteLine(myclass2.Add1());		//使用MyClass2类对象调用基类中的方法
            Console.WriteLine(myclass2.Add2());		//调用MyClass2类中的Add2方法求和
            Console.Read();
        }
    }

}
