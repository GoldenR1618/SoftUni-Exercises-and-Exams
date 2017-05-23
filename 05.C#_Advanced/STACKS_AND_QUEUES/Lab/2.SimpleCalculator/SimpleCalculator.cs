namespace _2.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');

            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                String op = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+":
                        stack.Push((first + second).ToString()); break;
                    case "-":
                        stack.Push((first - second).ToString()); break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
