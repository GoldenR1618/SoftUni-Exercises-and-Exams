using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        ListyIterator<string> list = null;

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                switch (args[0])
                {
                    case "Create":
                        list = new ListyIterator<string>(args.Skip(1));
                        break;

                    case "Move":
                        Console.WriteLine(list.Move());
                        break;

                    case "Print":
                        list.Print();
                        break;

                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;

                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", list));
                        break;

                    default:
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            input = Console.ReadLine();
        }
    }
}