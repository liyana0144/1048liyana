using System;

namespace ConsoleApp3_hww
{
    class Program
    {
        static void Main(string[] args)
        {
			int num;
			Console.Write("input your password : ");
			num = int.Parse(Console.ReadLine());
			string agency;
			Console.Write("input the Agency : ");
			agency = Console.ReadLine();

			if (agency == "CIA")
			{
				if (num < 1000000)
				{
					if (num % 10 % 3 == 0)
					{
						if ((num / 10) % 10 != 1 && (num / 10) % 10 != 3 && (num / 10) % 10 != 5)
						{
							if ((num / 100) % 10 >= 6 && (num / 100) % 10 != 8)
							{
								Console.Write("your password is correct");
							}
							else
							{
								Console.Write("your password is wrong");
							}
						}
						else
                        {
							Console.Write("your password is wrong");
						}

					}
					else
					{
						Console.Write("your password is wrong");
					}
				}
				else
				{
					Console.Write("your password is wrong");
				}
			}
			else if(agency  != "CIA")
            {
				Console.Write("your password is wrong");
			}
           
			else if (agency == "FBI")
			{
				if (num < 1000000)
                {
					if ((num / 100000) >=4 && (num / 100000) <= 6)
                    {
						if ((num / 100)%10 %2 ==0 && (num / 100) % 10 != 6)
                        {
							if (((num / 10000) % 10) % 2 != 0)
                            {
								Console.Write("your password is correct");
							}
							else
                            {
								Console.Write("your password is wrong");
							}

						}
						else
                        {
							Console.Write("your password is wrong");
						}
                    }
					else
                    {
						Console.Write("your password is wrong");
					}
                }
				else
                {
					Console.Write("your password is wrong");
				}
			}
			else if (agency != "FBI")
			{
				Console.Write("your password is wrong");
			}
			else if (agency == "NSA")
			{
				if (num < 1000000)
                {
					if (num % 10 % 30 == 0)
                    {
						if(( num / 100) % 10 % 3 == 0 && (num / 100) % 10 % 2 != 0)
                        {
							if (num % 10 == 7 || (num / 10) % 10 == 7 || (num / 100) % 10 == 7 || (num / 1000) % 10 == 7 || (num / 10000) % 10 == 7 || num / 100000 == 7)
                            {
								Console.Write("your password is correct");
							}
							else
                            {
								Console.Write("your password is wrong");
							}

						}
						else
                        {
							Console.Write("your password is wrong");
						}
                    }
					else
                    {
						Console.Write("your password is wrong");
					}
                }
				else
                {
					Console.Write("your password is wrong");
				}
			}
			else if (agency != "NSA")
			{
				Console.Write("your password is wrong");
			}
			Console.ReadLine();
		}
	}
    
}
