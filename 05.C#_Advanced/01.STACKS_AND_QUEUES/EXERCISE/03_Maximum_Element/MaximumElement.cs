namespace _03_Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElement
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();
            int maxNum = 0;

            for (int i = 1; i <= n; i++)
            {
                List<int> nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int querie = nums[0];

                switch (querie)
                {
                    case 1:
                        int x = nums[1];
                        numbers.Push(x);

                        if (x > maxNum)
                        {
                            maxNum = x;
                        }
                        break;

                    case 2:
                        int current = numbers.Pop();

                        if (current == maxNum && numbers.Count > 0)
                        {
                            maxNum = numbers.Max();
                        }
                        else if (current == maxNum && numbers.Count == 0)
                        {
                            maxNum = 0;
                        }
                        break;

                    case 3:

                        Console.WriteLine(maxNum);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}