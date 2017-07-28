using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        CustomStack<int> stack = new CustomStack<int>();

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] args = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] parsed = args.Skip(1).Select(int.Parse).ToArray();

            try
            {
                switch (args[0])
                {
                    case "Push":
                        stack.Push(parsed);
                        break;

                    case "Pop":
                        stack.Pop();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            input = Console.ReadLine();
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}