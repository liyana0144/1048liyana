using System;

namespace ConsoleApp5_h6
{
    class Program
    {
        enum Difficulty
        {
            Easy,
            Normal,
            Hard

        }
        struct Problem
        {
            public string Message;
            public int Answer;
            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;

            }
        }
        static void Main(string[] arge)
        {
            double point = 0;
            Difficulty level = 0;
            menuPG(point, level);
        }
        static void menuPG(double pt1, Difficulty pt2)
        {
            int numPG;
            Console.WriteLine("Score:{0},Difficulty:{1}", pt1, pt2);
            check(out numPG);
            if (numPG == 0)
            {
                playPG(pt1, pt2);
            }
            else if (numPG == 1)
            {
                settingPG(pt1, pt2);
            }
            else if (numPG == 2)
            {
                Console.WriteLine();
            }

        }
        static void check(out int PG)
        {
            do
            {
                PG = int.Parse(Console.ReadLine());
                if (PG != 0 && PG != 1 && PG != 2)
                {
                    Console.WriteLine("Please input 0-2");
                }

            }
            while (PG != 0 && PG != 1 && PG != 2);
        }
        static void playPG(double point, Difficulty level)
        {
            int d = (int)level;
            double Ans;
            Double Qc = 0;
            double Qa;
            Problem[] RandomProblems = GenerateRandomProblems(d * 2 + 3);
            long START = DateTimeOffset.Now.ToUnixTimeSeconds();

            for (int i = 0; i < RandomProblems.Length; i++)
            {
                Console.WriteLine(RandomProblems[i].Message);
                Console.WriteLine();
                Ans = int.Parse(Console.ReadLine());
                if (Ans == RandomProblems[i].Answer)
                {
                    Qc = Qc + 1;
                }
            }
            long STOP = DateTimeOffset.Now.ToUnixTimeSeconds();
            long timerange = STOP - START;
            Qa = d * 2 + 3;
            point = point + ((Qc / Qa) * ((25 - Math.Pow(d, 2)) / Math.Max(timerange, 25 - (double)Math.Pow(d, 2))) * (Math.Pow(2 * d + 1, 2)));
            menuPG(point, level);
        }
        static void settingPG(double point, Difficulty level)
        {
            int levelnum;
            Console.WriteLine("Score:{0},Difficulty: { 1}", point, (Difficulty)level);
            do
            {
                levelnum = int.Parse(Console.ReadLine());
                if (levelnum != 0 && levelnum != 1 && levelnum != 2)
                {
                    Console.WriteLine("please input 1-2");
                }
            }
            while (levelnum != 0 && levelnum != 1 && levelnum != 2);
            level = (Difficulty)levelnum;
            menuPG(point, level);
        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }
    }
}
