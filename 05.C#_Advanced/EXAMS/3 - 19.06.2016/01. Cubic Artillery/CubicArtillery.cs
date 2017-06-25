namespace _01.Cubic_Artillery
{
    using System;
    using System.Collections.Generic;

    public class CubicArtillery
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> bunkers = new Queue<string>();
            Queue<int> weapons = new Queue<int>();

            int leftCapacity = maxCapacity;

            while (input != "Bunker Revision")
            {
                string[] tokens = input.Split(' ');

                foreach (var element in tokens)
                {
                    bool isDigit = int.TryParse(element, out int weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        bool isSaved = false;

                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                            }

                            weapons.Clear();
                            leftCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (leftCapacity < weapon)
                                {
                                    leftCapacity += weapons.Dequeue();
                                }

                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
