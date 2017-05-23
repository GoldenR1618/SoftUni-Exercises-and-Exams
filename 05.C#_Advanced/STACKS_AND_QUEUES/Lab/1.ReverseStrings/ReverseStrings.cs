namespace _1.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class ReverseStrings
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
