using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alt = new ArrayList();				//实例化ArrayList类
            alt.Add("流浪地球");					//使用Add方法向对象中添加数据
            alt.Add("疯狂的外星人");						//使用Add方法向对象中添加数据
            alt.Add("飞驰人生");						//使用Add方法向对象中添加数据
            alt.Add("新喜剧之王");							//使用Add方法向对象中添加数据
            alt.Add("廉政风云");						//使用Add方法向对象中添加数据
            Console.WriteLine("2019春节档热门上映电影：");		//输出提示
            foreach (string InternetName in alt)				//使用foreach语句输出数据
            {
                Console.WriteLine(InternetName);			//输出ArrayList对象中的所有数据
            }
            Console.ReadLine();

        }
    }
}
