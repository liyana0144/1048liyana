using System;

namespace ConsoleApp3_ได้สักทีTT_สอบ2จ่ะ
{
    class Program
    {
        static void Main(string[] args)
        {
            int Round = 1;
            int box1, box2, box3;
            Console.Write("input your box in the bucket1:");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("input your box in the bucket2:");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("input your box in the bucket3:");
            box3 = int.Parse(Console.ReadLine());
            int all = box1 + box2 + box3;
            do
            {

                if (Round % 2 != 0)

                {
                    int bucketa, box;
                    Console.Write("player a ,select your bucket:");
                    bucketa = int.Parse(Console.ReadLine());
                    Console.Write("now, select the box that you want get it out :");
                    box = int.Parse(Console.ReadLine());
                    switch (bucketa)
                    {
                        case 1:

                            all = all - box;
                            Round = Round + 1;
                            break;
                        case 2:

                            all = all - box;
                            Round = Round + 1;
                            break;
                        case 3:

                            all = all - box;
                            Round = Round + 1;
                            break;
                    }
                    if (all == 0)
                    {
                        Console.Write("player B is WINNER!");
                    }

                }
                else
                {
                    int bucketb, boxx;
                    Console.Write("player b ,select your bucket:");
                    bucketb = int.Parse(Console.ReadLine());
                    Console.Write("now, select the box that you want get it out :");
                    boxx = int.Parse(Console.ReadLine());
                    switch (bucketb)
                    {
                        case 1:

                            all = all - boxx;
                            Round = Round + 1;
                            break;
                        case 2:

                            all = all - boxx;
                            Round = Round + 1;
                            break;
                        case 3:

                            all = all - boxx;
                            Round = Round + 1;
                            break;
                    }
                    if (all == 0)
                    {
                        Console.Write("player A is WINNER!");
                    }

                }
            }
            while (all > 0);

            Console.ReadLine();
        }
    }
}
