namespace Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Lists
    {
        public static void Main(string[] args)
        {
            /*
            List<T> holds a list of elements. Holds elements like an array, but can have a variable length.

            Has several methods for manipulation:
            1. Count – the number of elements in the List<T>
            2. Add() – adds an element to the List<T>                           - listOfNumbers.Add(145); - добавя 145.
            3. Remove() – returns true if it finds the element and removes it   - ListOfNumbers.Remove(145); - Ще изтире 145;
            4. RemoveAll() - изстрива всички зададени елементи                  - ListOfNumbers.RemoveAll(145); - ще изтрие всички числа на стойност 145. 
                                                                                - ListOfNumbers.RemoveAll(x => x % 2 == 0); - изтрий всички четни числа.
                                                                                - ListOfNumbers.RemoveAll(x => ___________ && ________ || _______); - всякакви условия можем да задаваме тук.
            5. RemoveAt(int index) – removes element at index                   - ListOfNumbers.RemoveAt(3); - изтрий числото с индекс позиция 3.
            6. Insert() – inserts an element to given position                  - ListOfNumbers.Insert(2, 5); - на втора позиция вкарва 5.
            7. Contains() – determines whether an element is in the list        - ListOfNumbers.Contains(5) - връща булева стойност дали съществува 5.
            8. Sort() – sorts the array in ascending order                      - ListOfNumbers.Sort();
            9. Reverse() - сортиране на обратно.                                - ListOfNumbers.Sort(); ListOfNumbers.Reverse(); - ако изпуснем първо да сортираме, ще ревърсне оригиналната подредба.
            10. FindAll() - връща лист на базата на някакво условие.            - var evenNumbers = ListOfNumbers.FindAll(x => x % 2 == 0); - дай ми всички четни числа.
            11. Count() - брои колко елемента отговарят на зададените условия.  - ListOfNumbers.Count(x => x == 30); - брои всички числа със стойност 30.
            12. AddRange() - добавя рейндж от елементи.                         - ListOfNumbers.AddRange(anotherList); - добавя всички елементи от друг лист.
            13. ForEach() - директно извежда целият Лист.                       - ListOfNumbers.ForEach(Console.WriteLine);
            */

            //Четене на Лист от конзолата - цифра по цифра, при предварително зададен брой въвеждания:
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            //Четене на Лист от една линия:

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //Принтиране на Лист в конзолата с for цикъл:
            List<string> textNumbers = new List<string>() { "one", "two", "three", "four", "five" };

            for (int index = 0; index < textNumbers.Count; index++)
            {
                Console.WriteLine($"arr[{index}] = {textNumbers[index]}");
            }

            //Принтиране на Лист в конзолата със string.Join:
            Console.WriteLine(string.Join(" => ", textNumbers));

            //Принтиране на Лист в конзолата със foreach:
            foreach (var number in textNumbers)
            {
                Console.WriteLine(number);
            }

            //Принтиране на Лист в конзолата със ForEach():
            textNumbers.ForEach(Console.WriteLine);

            //Сортиране на Листове:
            var names = new List<string>() { "Nakov", "Angel", "Ivan", "Atanas", "Boris" };

            names.Sort();                                   //Sort in natural order (ascending).

            Console.WriteLine(string.Join(", ", names));    // Angel, Atanas, Boris, Ivan, Nakov

            names.Sort();
            names.Reverse();                                //Sort in descending order.

            Console.WriteLine(string.Join(", ", names));    // Nakov, Ivan, Boris, Atanas, Angel

            //Лист който сърдържа само уникални стойности.
            HashSet<int> hash = new HashSet<int>();

            //Лист който съдържа само уникални сортирани стойности.
            SortedSet<int> sort = new SortedSet<int>();
        }
    }
}
