namespace _02_Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] comm = input.Split();

                switch (comm[0])
                {
                    case "exchange":
                        int index = int.Parse(comm[1]);

                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        arr = Exchange(arr, index + 1);    //splits the array after the given index => index + 1
                        break;

                    case "max":
                    case "min":
                        string maxMin = comm[0];
                        string evenOdd = comm[1];

                        Console.WriteLine(IndexMaxMinEvenOdd(arr, maxMin, evenOdd));
                        break;

                    case "first":
                    case "last":
                        string firstLast = comm[0];
                        int count = int.Parse(comm[1]);
                        string oddEven = comm[2];

                        Console.WriteLine(FirstLastCountEvenOdd(arr, firstLast, count, oddEven));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        //Splits the array after the given E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
        public static int[] Exchange(int[] arr, int index)
        {
            return arr.Skip(index).Concat(arr.Take(index)).ToArray();       //Пропусни index на брой числа, към останалите залепи index на брой числа.
        }

        //Returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4--------
        public static string IndexMaxMinEvenOdd(int[] arr, string maxMin, string evenOdd)
        {
            int remainder = evenOdd == "odd" ? 1 : 0;       //Дефинирам остатъка - 0 при четни, 1 при нечетни
            int[] filteredArr = arr.Where(n => n % 2 == remainder).ToArray();   //Тук са вече всички четни или всички нечетни числа

            if (!filteredArr.Any()) //Имали съвпадения?
            {
                return "No matches";
            }

            return maxMin == "min" ? Array.LastIndexOf(arr, filteredArr.Min()).ToString() : Array.LastIndexOf(arr, filteredArr.Max()).ToString();
        }

        //Returns the first/last {count} even/odd elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]---
        public static string FirstLastCountEvenOdd(int[] arr, string firstLast, int count, string oddEven)
        {
            if (count > arr.Length)     //Броя елементи не може да е по-голям от броя на ел. в масива.
            {
                return "Invalid count";
            }

            int remainder = oddEven == "odd" ? 1 : 0;       //Дефинирам остатъка - 0 при четни, 1 при нечетни
            int[] filteredArr = arr.Where(n => n % 2 == remainder).ToArray();   //Тук са вече всички четни или всички нечетни числа

            return firstLast == "first" ? $"[{string.Join(", ", filteredArr.Take(count))}]" : $"[{string.Join(", ", filteredArr.Reverse().Take(count).Reverse())}]";
        }
    }
}
