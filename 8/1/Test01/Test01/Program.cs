using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class MyClass
    {
        private string id = "";			 	//定义一个string类型的变量，用来记录用户编号
        /// <summary>
        ///定义用户编号属性，该属性为可读可写属性
        /// </summary>
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string name = "";			//定义一个string类型的变量，用来记录用户姓名
        /// <summary>
        ///定义用户姓名属性，该属性为可读可写属性
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();						//实例化MyClass类对象
            myclass.ID = "BH001";								//为用户编号属性赋值
            myclass.Name = "TM1";							//为用户姓名属性赋值
            Console.WriteLine(myclass.ID + " " + myclass.Name);		//输出用户编号和用户姓名
            myclass.ID = "BH002";								//重新为用户编号属性赋值
            myclass.Name = "TM2";							//重新为用户姓名属性赋值
            Console.WriteLine(myclass.ID + " " + myclass.Name);		//再次输出用户编号和用户姓名
            Console.Read();
        }
    }

}
