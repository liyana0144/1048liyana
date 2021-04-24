using System;

namespace ConsoleApp3_มิดเทอมมม
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            A = Console.ReadLine();
            int Wide, high, number,r;
            Wide = int.Parse(Console.ReadLine());
            high = int.Parse(Console.ReadLine());
            number = int.Parse(Console.ReadLine());
            r = 1;
            while (r <=number)
            {
                for (int i = 1; i <= high; i++)
                {
                    for (int k=1;k<=r*Wide;k++)
                    {
                        Console.Write(A);
                    }
                    Console.WriteLine();
                }
                r++;
            }
            Console.ReadLine();

        }
        
    }
}
