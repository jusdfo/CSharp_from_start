using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test08
{
    public sealed class myClass
    {
        private string name = "";//string类型变量,用来记录用户名
        private string pwd = "";//string类型变量,用来记录密码
        /// <summary>
        /// 用户名
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
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass myclass = new myClass();	//实例化密封类对象
            myclass.Name = "Tsoft";				//为密封类中的编号属性赋值
            myclass.Pwd = "111";				//为密封类中的名称属性赋值
            Console.WriteLine("用户名：" + myclass.Name + "\n密  码：" + myclass.Pwd);
            Console.Read();
        }
    }

}
