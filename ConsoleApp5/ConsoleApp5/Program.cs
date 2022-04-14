using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop 迴圈示範
            // for 迴圈
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine($"i:{i}");
            }

            Console.WriteLine("--------------------------------");
            for (int i = 10;i > 0; i--)
            {
                Console.WriteLine($"i:{i}");
            }

            Console.WriteLine("--------------------------------");
            // break 中斷
            for (int i = 0; i <= 20; i++)
            {
                if (i >= 9)
                {
                    Console.WriteLine($"i:{i}");
                    break;
                }
                Console.WriteLine($"i:{i}");
            }
            
            Console.WriteLine("--------------------------------");
            // continue 跳過此次迴圈
            for (int i = 0; i <= 10; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                Console.WriteLine($"i:{i}");
            }

            Console.WriteLine("--------------------------------");

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            for (int i = 0; i <= 5; i++)
            {
                for (int n = 0; n <= 10; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                   Console.Write("*");
                }
                for (int m = 0; m < i; m++)
                {
                    Console.Write(" ");
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            for (int i = 1; i < 10; i++)
            {
                
                for (int m = 1; m < 10; m++)
                {
                    int answer = m * i;
                    Console.Write($"{m} * {i} = {answer}, ");
                }
                Console.WriteLine();
                }
               // 練習 輸出 等腰三角形 , 輸出菱形
               //課程作業加分題: 請輸出聖誕樹 彩色 有裝飾(可以任意輸入聖誕樹的高度)

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
        }
    }
}
