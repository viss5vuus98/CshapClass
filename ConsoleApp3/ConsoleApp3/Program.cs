using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //算數運算子
            int x = 9;
            int y = 4;
            int z;
            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;

            int x2 = 5;
            double y2 = 0.02344;


            Console.WriteLine($"z的值是:{z}");

            //算術指定運算子
            int c = 250;
            c = c + 3; //253
            c += 3;  // 256
            c -= 6; //250
            c *= 2; //500
            c /= 2; // 250
            int d = 100;
            c += d; // c = 350
            Console.WriteLine($"C的值為{c}");
            Console.WriteLine("-------------------------");

            //遞增運算子
            int r = 8;
            r++; //r = r + 1
            r--; //r = r - 1

            Console.WriteLine($"r的值為:{r}");
            Console.WriteLine("--------------------------");

            //關係運算子
            int m = 30;
            double n = 65.33;
            bool compare;

            compare = m == n;

            Console.WriteLine($"compare:{compare}");
            Console.WriteLine("--------------------------");

            //複合關係運算
            float p = 56.78f;
            float w = 92.31f;
            bool logic;

            logic = p < w && p >= 50.0f; //AND
            logic = p > 60.0f && p != w;
            logic = w <= 80.0f || p <= w;
            logic = p > w || w < 20.0f;
            logic = p > 40.0f && w < 120.0f && p == w;
            logic = p > 10.0f || w > 75.0f || p >= w;
            logic =  p > 20.0f || w < 50.0f  && p < w;
            logic = !(w < p);



            Console.WriteLine($"logic:{logic}");
            Console.WriteLine("----------------------------");


            Console.WriteLine("any key to stop");
            Console.ReadKey();

        }
    }
}
