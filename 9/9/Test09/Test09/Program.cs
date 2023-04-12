﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test09
{
    class MyClass1
    {
        private int width = 0;							//定义int型变量，作为矩形的长
        private int height = 0;							//定义int型变量，作为矩形的宽
        /// <summary>
        /// 长
        /// </summary>
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        /// <summary>
        /// 宽
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
    }
    /// <summary>
    /// 自定义类，该类继承自MyClass1
    /// </summary>
    class MyClass2 : MyClass1
    {
        /// <summary>
        /// 求矩形的面积
        /// </summary>
        /// <returns>矩形的面积</returns>
        public int Area()
        {
            return Width * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 myClass2 = new MyClass2();
            myClass2.Width = 5;
            myClass2.Height = 3;
            Console.WriteLine("矩形的面积为：" + myClass2.Area());
            Console.Read();
        }
    }
}
