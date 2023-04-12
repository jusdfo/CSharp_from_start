using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        class test									//创建一个类
        {
            public int MyInt(string a, string b)				//创建一个int类型的方法，参数分别是a和b
            {
                int int1;								//声明一个int类型的变量int1
                int int2;								//声明一个int类型的变量int2
                int num;								//声明一个int类型的变量num
                try									//使用try…catch语句
                {
                    int1 = int.Parse(a);					//将参数a强制转换成int类型后赋给int1
                    int2 = int.Parse(b);					//将参数b强制转换成int类型后赋给int2
                    if (int2 == 0)						//判断int2是否等于0，如果等于0，抛出异常
                    {
                        throw new DivideByZeroException();//抛出DivideByZeroException类的异常
                    }
                    num = int1 / int2;					//计算int1除以int2的值
                    return num;						//返回计算结果
                }
                catch (Exception ex)			//捕获异常
                {
                    //Console.WriteLine("用零除整数引发异常！");
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            try									//使用try…catch语句
            {
                Console.WriteLine("请输入分子：");		//提示输入分子
                string str1 = Console.ReadLine();			//获取键盘输入的值
                Console.WriteLine("请输入分母：");		//提示输入分母
                string str2 = Console.ReadLine();			//获取键盘输入的值
                test tt = new test();						//实例化test类
                //调用test类中的MyInt方法，获取键盘输入的分子与分母相除得到的值
                Console.WriteLine("分子除以分母的值：" + tt.MyInt(str1, str2));
            }
            catch (Exception ex)						//捕获异常
            {
                Console.WriteLine(ex.Message);	//输出提示
            }
            Console.ReadLine();
        }

    }
}
