using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test08
{
    class Program
    {
        public struct Round//定义一个圆形结构
        {
            public double r;//圆形的半径
            /// <summary>
            /// 计算圆形面积
            /// </summary>
            /// <returns>圆形面积</returns>
            public double Area()
            {
                return Math.PI * r * r;
            }
        }
        static void Main(string[] args)
        {
            Round myRound;//实例化圆形结构
            myRound.r = 5;//为圆半径赋值
            Console.WriteLine("圆形面积为：" + myRound.Area());
            Console.Read();
        }
    }
}
