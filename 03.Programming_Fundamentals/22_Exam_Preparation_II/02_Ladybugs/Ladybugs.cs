namespace _02_Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            List<int> ladybugIndexes = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .Where(x => x >=0 && x < fieldSize).ToList();

            int[] ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugIndexes.Count; i++)     //Зареждане на калинките в полето.
            {
                ladybugs[ladybugIndexes[i]] = 1;
            }

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                int oldPosition = int.Parse(tokens[0]);
                string direction = tokens[1];
                int length = int.Parse(tokens[2]);

                int newPosition = 0;

                if (direction == "right")
                {
                    newPosition = oldPosition + length;
                }
                else
                {
                    newPosition = oldPosition - length;
                }

                if (oldPosition >= 0 && oldPosition < ladybugs.Length)
                {
                    if (ladybugs[oldPosition] == 1)
                    {
                        ladybugs[oldPosition] = 0;

                        while (true)
                        {
                            if (newPosition > ladybugs.Length - 1 || newPosition < 0)
                            {
                                break;
                            }

                            if (ladybugs[newPosition] == 0)
                            {
                                ladybugs[newPosition] = 1;
                                break;
                            }
                            else
                            {
                                if (direction == "right")
                                {
                                    newPosition = newPosition + length;
                                }
                                else
                                {
                                    newPosition = newPosition - length;
                                }
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
