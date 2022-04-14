using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // if .....else 條件判斷式
            int x = 40;
            int y = 40;

            if (x < y && x > 10 || x < 50)
            { //true
                Console.WriteLine("x > y");
            }else
            { // x > y false
                Console.WriteLine("x <= y");
            }

            if (x > y)
            {
                Console.WriteLine("x > y");
            }else
            {
                if (x == y)
                {
                    Console.WriteLine("x = y");
                }
                else
                {
                    Console.WriteLine("x < y");
                }
            }

            if (x == y)
            {
                Console.WriteLine("x = y");

            }
            else if (x > y)
            {
                Console.WriteLine("x > y");
            }
            else
            {
                Console.WriteLine("x < y");
            }

            //if...else  簡式

            int w = 12;
            int s = 6;
            if (w < 0)
            {
                s = -1;
            }else
            {
                s = w * 2;
            }
            Console.WriteLine($"s = {s}");

            s = (w < 0) ? -1 : (w * 2);
            Console.WriteLine($"簡式s = {s}");

            string ss = Console.ReadLine()
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


            Console.WriteLine("-------------------------");
            Console.ReadLine();
        }
    }
}
