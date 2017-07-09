using System;
using System.Collections.Generic;
using System.Linq;

class RageQuit
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();

        var bigList = new List<char>();
        var currlist = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (!Char.IsNumber(ch))
            {
                currlist.Add(ch);
            }

            if (Char.IsNumber(ch))
            {
                int count = 0;

                if (i < input.Length - 1 && Char.IsNumber(input[i + 1]))    //Ако символа не е последен в стринга, а следващият също е число.
                {
                    string str = input.Substring(i, 2);     //The repeat count for each string will be an integer in the range [0 … 20]
                    count = int.Parse(str.ToString());
                }
                else
                {
                    count = int.Parse(ch.ToString());       //Добавяме текущото открито число към брояча.
                }

                if (count > 0)                              //Ако в брояча вече имаме зардено число.
                {
                    for (int j = 0; j < count; j++)
                    {
                        bigList.AddRange(currlist);         //Зареждаме в основният лист текущата поредица count пъти.
                    }
                }

                currlist.Clear();
            }
        }

        string result = new string(bigList.ToArray());

        Console.WriteLine("Unique symbols used: {0}", result.Distinct().Count());
        Console.WriteLine(result);
    }
}