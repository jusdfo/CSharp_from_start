using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    public abstract class myClass
    {
        private string id = "";
        private string name = "";
        /// <summary>
        /// 编号属性及实现
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
        /// 姓名属性及实现
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
        /// 抽象方法，用来输出信息
        /// </summary>
        public abstract void ShowInfo();
    }
    public class DriveClass : myClass					//继承抽象类
    {
        /// <summary>
        /// 重写抽象类中输出信息的方法
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DriveClass driveclass = new DriveClass();		//实例化派生类
            myClass myclass = driveclass;				//使用派生类对象实例化抽象类
            myclass.ID = "BH0001";					//使用抽象类对象访问抽象类中的编号属性
            myclass.Name = "TM";						//使用抽象类对象访问抽象类中的姓名属性
            myclass.ShowInfo();						//使用抽象类对象调用派生类中的方法
            Console.Read();
        }
    }

}
