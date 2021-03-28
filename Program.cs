using System;

namespace ConsoleApp3_สอบจ่ะสอบ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("input number:");
            a = int.Parse(Console.ReadLine());
            Console.Write("input number:");
            b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
