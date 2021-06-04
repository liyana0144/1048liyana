using System;

namespace ConsoleApp5hw5edit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("in number 1-7 have menu for diet in one week.");
            Console.WriteLine("Please, choose one number in one day only");
            Console.WriteLine("input number :");
            int daynum = int.Parse(Console.ReadLine());

            switch (daynum)
            {
                case 1:
                    Console.WriteLine("breakfast : rice porridge with chicken breast and orange juice");
                    Console.WriteLine("afternoon : Spicy minced chicken breast with riceberry");
                    Console.WriteLine("dinner : stir-fried glass noodle with vegetables");
                    break;
                case 2:
                    Console.WriteLine("breakfast : whole weed bread with fried egg and low fat milk");
                    Console.WriteLine("afternoon : chicken noodle");
                    Console.WriteLine("dinner : chicken breast salad with yogurt");
                    break;
                case 3:
                    Console.WriteLine("breakfast : granola and banana with almond milk");
                    Console.WriteLine("afternoon : Spicy chicken breast with basil leaves and riceberry");
                    Console.WriteLine("dinner : pork noodle");
                    break;
                case 4:
                    Console.WriteLine("breakfast : brown rice with omlet no oil and fruit");
                    Console.WriteLine("afternoon : papaya salad and Grilled chicken");
                    Console.WriteLine("dinner : Grilled fish salad with boiled egg");
                    break;
                case 5:
                    Console.WriteLine("breakfast : whole weed bread with penut butter and low fat milk");
                    Console.WriteLine("afternoon : pumpkin with fried egg,1 boiled egg and brown rice");
                    Console.WriteLine("dinner : Spicy noodle salad");
                    break;
                case 6:
                    Console.WriteLine("breakfast : Porridge brow rice with fish");
                    Console.WriteLine("afternoon : Shrimp-paste sauce,fried mackerel,vegetables and rice");
                    Console.WriteLine("dinner : Steamed Egg and rice");
                    break;
                case 7:
                    Console.WriteLine("breakfast : whole weed bread with fried egg and orange juice");
                    Console.WriteLine("afternoon : stir-fried glass noodle with vegetables and fruit");
                    Console.WriteLine("dinner : Porridge with egg ");
                    break;
                default:
                    Console.WriteLine("you put wrong number, please try again");
                    break;
            }
        }
    }
}
