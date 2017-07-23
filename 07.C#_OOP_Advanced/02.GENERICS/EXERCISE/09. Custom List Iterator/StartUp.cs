using System;

public class StartUp
{
    public static void Main()
    {
        CustomizedList<string> list = new CustomizedList<string>();

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = args[0];

            switch (command)
            {
                case "Add":
                    list.Add(args[1]);
                    break;

                case "Remove":
                    list.Remove(int.Parse(args[1]));
                    break;

                case "Contains":
                    Console.WriteLine(list.Contains(args[1]));
                    break;

                case "Swap":
                    list.Swap(int.Parse(args[1]), int.Parse(args[2]));
                    break;

                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(args[1]));
                    break;

                case "Max":
                    Console.WriteLine(list.Max());
                    break;

                case "Min":
                    Console.WriteLine(list.Min());
                    break;

                case "Print":
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "Sort":
                    list.Sort();
                    break;

                default:
                    break;
            }

            input = Console.ReadLine();
        }
    }
}
