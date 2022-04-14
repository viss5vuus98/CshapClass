using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("輸入布丁 a | 冰淇淋 b | 奶酪 c| 紅豆湯 d|");
                Console.WriteLine("結束選單請輸入\"x\"");
                Console.WriteLine("輸入完成請按Enter");
                string ss = Console.ReadLine();
                if (ss == "x")
                {
                    break;
                }

                switch (ss) //填入基本資料型態 除浮點數
                {
                    case "a":
                        Console.WriteLine("你選了布丁");
                        break;
                    case "b":
                        Console.WriteLine("你選了冰淇淋");
                        break;
                    case "c":
                        Console.WriteLine("你選了奶酪");
                        break;
                    case "d":
                        Console.WriteLine("你選了紅豆湯");
                        break;
                    default:
                        Console.WriteLine("無此產品");
                        break;
                }
                


                /*switch (ss) //填入基本資料型態 除浮點數
                {
                    case "a":
                        Console.WriteLine("你選了布丁");
                        break;
                    case "b":
                        Console.WriteLine("你選了冰淇淋");
                        break;
                    case "c":
                        Console.WriteLine("你選了奶酪");
                        break;
                    case "d":
                        Console.WriteLine("你選了紅豆湯");
                        break;
                    default:
                        Console.WriteLine("無此產品");
                        break; */
                Console.ReadLine();
            }
        }
    }
}
