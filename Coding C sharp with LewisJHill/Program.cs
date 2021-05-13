using System;

namespace Coding_C_sharp_with_LewisJHill
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice;
            Random rand = new Random();

            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int number4 = 0;
            int number5 = 0;
            int number6 = 0;

            for (int i =0; i <= 6000; i++)
            {
                dice = rand.Next(7);
                switch (dice)
                {
                    case 1:
                        number1++;
                        break;
                    case 2:
                        number2++;
                        break;
                    case3:
                        number3++;
                        break;
                    case 4:
                        number4++;
                        break;
                    case 5:
                        number5++;
                        break;
                    case 6:
                        number6++;
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
