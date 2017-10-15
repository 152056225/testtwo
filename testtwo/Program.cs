using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testtwo
{
    class Program
    {
        static void Main(string[] args)
        {
            cal a = new cal();
            a.caluate();
        }
    }
    class cal
    {
        public void caluate()
        {
            char s = 'Y';
            while (s == 'Y')
            {
                Console.WriteLine("请输入第一个操作数");
                string q = Console.ReadLine();
                Console.WriteLine("请输入第二个操作数");
                string w = Console.ReadLine();
                int az = Regex.Matches(q, @"[A-Za-z]").Count;  //判断字符串中是否含有字母
                int bz = Regex.Matches(w, @"[A-Za-z]").Count;
                //提示用户要进行的运算（加 ： +  减： -  乘： * 除： /）
                Console.WriteLine("请输入您想进行运算的操作符 （加 ： +  减： -  乘： * 除： /） ");
                //获得用户输入的操作符
                char c = char.Parse(Console.ReadLine());
                //根据用户输入的操作符进行相应的运算操作，并保存运算结果
                if (az != 0 || bz != 0)
                {
                    jisuan(q,w,c);       //字符串计算
                }
                else
                {
                    int a = Convert.ToInt32(q);
                    int b = Convert.ToInt32(w);
                    jisuan(a, b, c);     //数字计算
                }
                //提示用户继续还是退出（继续 Y   退出  E）
                Console.WriteLine("继续运算请输 Y  退出程序请输 E");
                //获得用户的选择
                s = char.Parse(Console.ReadLine());
                if (!((s == 'Y') || (s == 'E')))
                {
                    throw new ArgumentException("继续运算请输 Y  退出程序请输 E 已默认退出");
                }
            }
        }
        public void jisuan(string a,string b,char c) {
            switch (c)
            {
                case '+':
                    jia(a, b);
                    break;
                case '-':
                    jian(a, b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("输入的运算符不是加减乘除中的一个");
            }
        }
        public void jisuan(int a, int b, char c)
        {
            if (b == 0)
                throw new ArgumentOutOfRangeException("除数不能为零");
            double d = 0;
            switch (c)
            {
                case '+':
                    jia(a, b);
                    break;
                case '-':
                    jian(a, b);
                    break;
                case '*':
                    d = a * b;
                    break;
                case '/':
                    d = a / b;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("输入的运算符不是加减乘除中的一个");
            }
            //输出运算结果
            Console.WriteLine("结果为" + d);
        }
        public void jia(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public void jia(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void jian(string a, string b)
        {
            Console.WriteLine(a.Replace(b, ""));
        }
        public void jian(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}







