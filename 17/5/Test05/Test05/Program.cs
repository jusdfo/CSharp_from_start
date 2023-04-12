using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test05
{
    public class myClass1
    {
        /// <summary>
        /// 虚方法，用来显示信息
        /// </summary>
        public virtual void ShowInfo()
        {
        }
    }
    public sealed class myClass2 : myClass1			//密封类，继承自myClass1
    {
        private string id = "";						//string类型变量，用来记录编号
        private string name = "";					//string类型变量，用来记录名称
        /// <summary>
        /// 编号属性
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
        /// <summary>
        /// 名称属性
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
        /// 密封并重写基类中的ShowInfo方法
        /// </summary>
        public sealed override void ShowInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass2 myclass2 = new myClass2();		//实例化密封类对象
            myclass2.ID = "BH0001";				//为密封类中的编号属性赋值
            myclass2.Name = "TM";				//为密封类中的名称属性赋值
            myclass2.ShowInfo();					//调用密封类中的密封方法
            Console.Read();
        }
    }

}
