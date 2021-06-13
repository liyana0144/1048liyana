using System;

namespace ConsoleApp5_f_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("matrix");

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                    Console.Write(arr[i, j]);
            }

            Console.ReadLine();
        }
    }
}
