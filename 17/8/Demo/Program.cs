using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        static void Main(string[] args)
        {
            SchoolRing sr = new SchoolRing();//创建学校铃声类
            Students student = new Students();//创建学生实例
            student.SubscribeToRing(sr);//订阅铃声
            Console.Write("请输入打铃参数（1：表示打上课铃；2：表示打下课铃）：");
            sr.Jow(Convert.ToInt32(Console.ReadLine()));//打铃动作
            Console.ReadLine();
        }
    }

    public delegate void RingEvent(int ringKind);//声明一个委托类型，参数ringKind表示铃声种类(1：表示上课铃声；2表示下课铃声)

    public class SchoolRing
    {
        public RingEvent OnBellSound;  //委托发布
        public void Jow(int ringKind)  //打铃
        {
            if (ringKind == 1 || ringKind == 2)
            {
                Console.Write(ringKind == 1 ? "上课铃声响了，" : "下课铃声响了，");
                if (OnBellSound != null)//不等于空，说明它已经订阅了具体的方法（即它已经引用了具体的方法）
                {
                    OnBellSound(ringKind);//回调OnBellSound委托所订阅（或引用）的具体方法
                }
            }
            else
            {
                Console.WriteLine("这个铃声参数不正确！");
            }
        }
    }

    public class Students
    {
        public void SubscribeToRing(SchoolRing schoolRing)  //学生们订阅铃声这个委托事件
        {
            schoolRing.OnBellSound += SchoolJow;
        }
        public void SchoolJow(int ringKind)
        {
            if (ringKind == 2)//打了下课铃
            {
                Console.WriteLine("同学们开始课间休息！");
            }
            else if (ringKind == 1)//打了上课铃
            {
                Console.WriteLine("同学们开始认真学习！");
            }
        }
        public void CancelSubscribe(SchoolRing schoolRing)//取消订阅铃声动作
        {
            schoolRing.OnBellSound -= SchoolJow;
        }


    }
}