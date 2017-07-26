using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]));

        input = Console.ReadLine().Split(' ');
        bool drunkOrNot = input[2] == "drunk";
        Console.WriteLine(new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), drunkOrNot));

        input = Console.ReadLine().Split();
        Console.WriteLine(new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]));
    }
}
