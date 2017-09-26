using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtwo
{
    class Program
    {
        static void Main(string[] args)
        {
            char s = 'Y';
            while (s == 'Y')
            {
                try
                {
                    //提示用户输入两个操作数
                    //获得用户输入的两个数据
                    Console.WriteLine("请输入第一个操作数");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二个操作数");
                    double b = double.Parse(Console.ReadLine());
                    if (b == 0)
                        throw new ArgumentOutOfRangeException("除数不能为零");
                    //提示用户要进行的运算（加 ： +  减： -  乘： * 除： /）
                    Console.WriteLine("请输入您想进行运算的操作符 （加 ： +  减： -  乘： * 除： /） ");
                    //获得用户输入的操作符
                    char c = char.Parse(Console.ReadLine());
                    //根据用户输入的操作符进行相应的运算操作，并保存运算结果

                    double d = 0;
                    switch (c)
                    {
                        case '+':
                            d = a + b;
                            break;
                        case '-':
                            d = a - b;
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
                    //提示用户继续还是退出（继续 Y   退出  E）
                    Console.WriteLine("继续运算请输 Y  退出程序请输 E");
                    //获得用户的选择
                    s = char.Parse(Console.ReadLine());
                    if (!((s == 'Y') || (s == 'E')))
                    {
                        throw new ArgumentException("继续运算请输 Y  退出程序请输 E 已默认退出");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("异常信息:{0}", ex.Message);
                }
            }
        }
    }
}
