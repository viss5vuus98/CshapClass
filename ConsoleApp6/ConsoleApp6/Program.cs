using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            while (true)
            {
                Console.WriteLine("hello World");
                break;
            }
            Console.WriteLine("------------------------------");
            int d = 1;
            while (true)
            {
                if (d > 10)
                {
                    break;
                }

                Console.WriteLine($"d:{d}");
                d += 1;
            }

            int dd = 1;
            while (dd <= 10)
            {
                Console.WriteLine($"d:{dd}");
                dd += 1;
            }




            Console.WriteLine("------------------------------");
            Console.ReadLine();
            // do .....while
            int g = 1;
            do
            {
                Console.WriteLine($"g:{g}");
                g += 1
            } while (g <= 10);




        }
    }
}
