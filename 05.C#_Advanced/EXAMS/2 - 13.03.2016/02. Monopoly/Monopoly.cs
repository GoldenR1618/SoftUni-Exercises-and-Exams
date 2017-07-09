namespace _02.Monopoly
{
    using System;
    using System.Linq;

    public class Monopoly
    {
        public static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = rc[0];
            int c = rc[1];

            int money = 50;
            int hotels = 0;
            int turns = 0;

            for (int i = 0; i < r; i++)
            {
                string hjfs = Console.ReadLine();

                for (int j = 0, k = c - 1; j < c; j++, k--)
                {
                    char current = ' ';

                    if (i % 2 == 0)
                    {
                        current = hjfs[j];
                    }
                    else
                    {
                        current = hjfs[k];
                    }

                    turns++;

                    switch (current)
                    {
                        case 'H':
                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money = 0 + (10 * hotels);
                            break;

                        case 'J':
                            Console.WriteLine($"Gone to jail at turn {turns - 1}.");
                            turns += 2;
                            money = money + (10 * hotels);
                            money = money + (10 * hotels);
                            money = money + (10 * hotels);
                            break;
                        case 'F':
                            money = money + (10 * hotels);
                            break;

                        case 'S':
                            int needMoney = 0;

                            if (i % 2 == 0)
                            {
                                needMoney = (i + 1) * (j + 1);
                            }
                            else
                            {
                                needMoney = (i + 1) * (k + 1);
                            }

                            if (needMoney <= money)
                            {
                                Console.WriteLine($"Spent {needMoney} money at the shop.");
                                money -= needMoney;
                            }
                            else
                            {
                                Console.WriteLine($"Spent {money} money at the shop.");
                                money -= money;
                            }
                            money = money + (10 * hotels);
                            break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}
