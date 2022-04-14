using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //三個數字比大小
            int a = 220;
            int b = 206;
            int c = 240;
            int one = a;
            int two = b;
            int tree = c;

            if (a > b)
            {
                one = a;
                two = b;
                tree = c;
                if (two < c)
                {
                    two = c;
                    tree = b;
                }
                else if (one < c)
                {
                    one = c;
                    two = a;
                    tree = b;
                }
            }
            else if (a < b)
            {
                one = b;
                two = a;
                tree = c;
                if (two < c)
                {
                    two = c;
                    tree = a;
                }
                else if (one < c)
                {
                    one = c;
                    two = b;
                    tree = a;
                }
            }
            else
            {
                if (one < c)
                {
                    one = c;
                    two = a;
                    tree = b;
                }
            }
            Console.WriteLine($"{one} | {two} | {tree}");


            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}
