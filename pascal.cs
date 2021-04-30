using System;

namespace ConsoleApp3_การบ้านน
{
    class Program
    {
        static void Main(string[] args)
        {

            int pascal, va;
            Console.Write("input your number : ");
            pascal = int.Parse(Console.ReadLine());

            va = 0;

            if (pascal  == 0)
            {
                Console.WriteLine("1");
            }
            else if (pascal  > 0)
            {
                pascal  = pascal  + 1;
                for (int i = 0; i < pascal ; i++)
                {
                    for (int k = 0; k <= i; k++)
                    {
                        if (k == 0 || i == 0)
                        {
                            va = 1;
                        }
                        else
                        {
                            va = va * (i - k + 1) / k;
                        }
                        Console.Write(va + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                
            }
        }
    }
}
