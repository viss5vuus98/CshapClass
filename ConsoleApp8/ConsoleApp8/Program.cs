using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array 陣列
            int[] arrayOne = new int[6];
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 5;
            arrayOne[5] = 6;

            Console.WriteLine("ArrayOne取出索引值為3的元素內容:{0}", arrayOne[3]);
            arrayOne[4] = 88;
            Console.WriteLine("ArrayOne取出索引值為4的元素內容:{0}", arrayOne[4]);

            int[] array2 = new int[] { 6, 5, 4, 3, 2, 1 };
            int[] array3 = { 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Array3取出索引值為4的元素內容:{0}", arrayOne[3]);


            Console.WriteLine("-------------------------遍例陣列");
            //遍例陣列

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine("arrayOne[{0}] = {1}", i, arrayOne[i]);
            }

            Console.WriteLine("-------------------------string陣列");
            string[] arrayClassName = { "國文", "數學", "自然", "英文", "社會"};

            Console.WriteLine($"array科目名稱[{1}] = {arrayClassName[1]}");

            Console.WriteLine("-------------------------遍例string陣列");
            for (int i = 0; i < arrayClassName.Length; i++)
            {
                Console.WriteLine($"array科目名稱[{i}] = {arrayClassName[i]}");
            }

            Console.WriteLine("-------------------------forEach");

            foreach (string subject in arrayClassName)
            {
                Console.WriteLine($"array科目名稱[{subject}]");
            }
            Console.WriteLine("--------------------------二維陣列");
            int[,] array2D_one = new int[4, 2];
            array2D_one[0, 0] = 8;
            array2D_one[0, 1] = 7;
            array2D_one[1, 0] = 6;
            array2D_one[1, 1] = 5;
            array2D_one[2, 0] = 4;
            array2D_one[2, 1] = 3;
            array2D_one[3, 0] = 2;
            array2D_one[3, 1] = 1;
            int[,] array2D_two = { { 8, 7 }, { 6, 5 }, { 4, 3 }, { 2, 1 } };

            Console.WriteLine("--------------------------遍歷二維陣列");
            for (int i = 0; i <= array2D_one.GetUpperBound(0); i++)
            {
                for (int n = 0; n <= array2D_one.GetUpperBound(1); n++)
                {
                   Console.WriteLine(array2D_one[i, n]);
                }
            }

            // 三維陣列
            int[,,] array3D_one = new int[2, 3, 4]
            {
                {
                    {1, 2, 3, 4},
                    {5, 6, 7, 8},
                    {9, 10, 11, 12}
                },
                {
                    {13, 14, 15, 16},
                    {17, 18, 19, 20},
                    {21, 22, 23, 24}
                }
            };
            Console.WriteLine("-------------------------");
            for (int i = 0; i <= array3D_one.GetUpperBound(0); i++)
            {
                for (int n = 0; n <= array3D_one.GetUpperBound(1); n++)
                {
                    for (int k = 0; k <= array3D_one.GetUpperBound(2); k++)
                    {
                        Console.WriteLine(array3D_one[i, n, k]);
                    }
                }
            };

            Console.WriteLine(array3D_one[1, 0, 2]);
            Console.WriteLine(array3D_one[0, 1, 2]);
            Console.WriteLine(array3D_one[1, 2, 2]);


            Console.Clear();
            Console.WriteLine("-------------------------Search Array element");

            Console.WriteLine("輸入搜尋科目名稱(輸入完成按Enter):");

            string strSearchSubject = Console.ReadLine();
            bool isSubject = false;


            for (int i = 0; i <= arrayClassName.GetUpperBound(0); i++)
            {
                if (arrayClassName[i] == strSearchSubject)
                {
                    Console.WriteLine("有此科目:" + arrayClassName[i] + ", index:" + i);
                    isSubject = true;
                    break;
                }

            }

            if (!isSubject)
            {
                Console.WriteLine("找不到此科目");
            }





            Console.WriteLine("-------------------------");
            Console.ReadLine();
        }
    }
}
