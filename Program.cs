using System;

namespace ConsoleApp3_มิดเทอมม
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, time;
            string order;
            Console.Write("input day that you want to order menu in 1-7(1 is for monday and 7 is for sunday): ");
            day = int.Parse(Console.ReadLine());
            Console.Write("input time that you want to order menu in 8-18 (8 is mean 8:00 o'clock and 18 is mean 18:00 o'clock): ");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine("we have breakfast set 5 sets per day,weekend set and 2 sets per day and coffee 3 sets per day");
            Console.WriteLine("please enter youe menu : ");
            order = Console.ReadLine();
            
        }
    }
}
