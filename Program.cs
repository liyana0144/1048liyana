using System;

namespace ConsoleApp3_hw_jaaa
{
    class Program
    {
        static void Main(string[] args)
        {

            string mode = Console.ReadLine();
            double  xt = double .Parse(Console.ReadLine());
            double  yp = double .Parse(Console.ReadLine());
            if (mode =="time" || mode == "price")
            {
                if (xt < 0)
                {
                    Console.Write("invalid mouse position");
                }
                else if (mode == "time")
                {
                    yp = Math.Pow((xt - 1), 2);
                    Console.Write("{0},{1}",xt, yp);
                }
                else if (mode == "price")
                {
                    xt = Math.Sqrt(yp) + 1;
                    Console.Write("{0},{1}", xt, yp);
                }
                    
            }
            else
            {
                Console.Write("invalid mode");
            }
            Console.ReadLine();
        }
    }
}
