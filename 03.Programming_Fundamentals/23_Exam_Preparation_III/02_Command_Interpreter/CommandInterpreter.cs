namespace _02_Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] comm = input.Split();

                string keyWord = comm[0];

                switch (keyWord)
                {
                    case "reverse":
                        int startR = int.Parse(comm[2].ToString());
                        int countR = int.Parse(comm[4].ToString());

                        if (startR >= 0 && startR < list.Count && countR >= 0 && (startR + countR) <= list.Count)
                        {
                            Reverce(list, startR, countR);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        int startS = int.Parse(comm[2].ToString());
                        int countS = int.Parse(comm[4].ToString());

                        if (startS >= 0 && startS < list.Count && countS >= 0 && (startS + countS) <= list.Count)
                        {
                            Sort(list, startS, countS);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        int countRL = int.Parse(comm[1].ToString());

                        if (countRL >= 0)
                        {
                            RollLeft(list, countRL);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        int countRR = int.Parse(comm[1].ToString());

                        if (countRR >= 0)
                        {
                            RollRight(list, countRR);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        private static void RollRight(List<string> list, int countRR)
        {
            string[] rollR = new string[list.Count];

            int newCount = countRR % rollR.Length;

            for (int i = 0; i < list.Count; i++)
            {
                if (i + newCount < rollR.Length)
                {
                    rollR[i + newCount] = list[i];
                }
                else
                {
                    rollR[i - (rollR.Length - newCount)] = list[i];
                }  
            }

            for (int j = 0; j < list.Count; j++)
            {
                list[j] = rollR[j];
            }
        }

        private static void RollLeft(List<string> list, int countRL)
        {
            string[] rollL = new string[list.Count];

            int newCount = countRL % rollL.Length;

            for (int i = 0; i < list.Count; i++)
            {
                if (i - newCount >= 0)
                {
                    rollL[i - newCount] = list[i];
                }
                else
                {
                    rollL[i + (rollL.Length - newCount)] = list[i];
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                list[j] = rollL[j];
            }
        }

        private static void Sort(List<string> list, int startS, int countS)
        {
            List<string> sorted = new List<string>();

            for (int i = startS; i < startS + countS; i++)
            {
                sorted.Add(list[i]);
            }

            sorted.Sort();

            for (int r = startS, j = 0; r < startS + countS; r++, j++)
            {
                list[r] = sorted[j];
            }
        }

        private static void Reverce(List<string> list, int startR, int countR)
        {
            List<string> reverce = new List<string>();

            for (int i = startR + countR - 1; i >= startR; i--)
            {
                reverce.Add(list[i]);
            }

            for (int r = startR, j = 0; r < startR + countR; r++, j++)
            {
                list[r] = reverce[j];
            }
        }
    }
}
