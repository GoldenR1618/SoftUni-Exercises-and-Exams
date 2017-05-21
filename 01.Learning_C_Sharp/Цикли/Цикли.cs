﻿namespace Цикли
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Цикли
    {
        public static void Main(string[] args)
        {
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int counter = 0;                                                    //Цикъл while.
            while (counter <= 9)
            {
                Console.WriteLine("Number: " + counter);
                counter++;
            }
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int n = int.Parse(Console.ReadLine());                              //Подкана за валидно число с цикъл while.
            while (n < 1 || n > 12)
            {
                Console.WriteLine("Невалидно число!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Числото е: " + n);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.Write("n = ");                                              //Цикъл do-while. Изчисляване на факториел от зададено число. 
            int nn = int.Parse(Console.ReadLine());
            decimal fact = 1;
            do
            {
                fact *= nn;
                nn--;
            } while (nn > 0);
            Console.WriteLine("n! = " + fact);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            for (var s = 1; s <= 100; s++)                                      //Цикъл for.
            {
                Console.WriteLine(s);
            }
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.Write("Latin alphabet:");                                   //for-циклите работят не само с числа, може и с букви.
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(" " + letter);
            }
            Console.WriteLine();
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            for (int small = 1, large = 10; small < large; small++, large--)    //for-цикъл с няколко променливи.
            {
                Console.WriteLine(small + " " + large);
            }
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };                     //Цикъл foreach. Задава се масив от цифри и имена, които се обхождат с циклите.
            foreach (int i2 in numbers)
            {
                Console.Write(" " + i2);
            }
            Console.WriteLine();

            String[] towns = { "Sof ia", "Plovdiv", "Varna", "Bourgas" };
            foreach (String town in towns)
            {
                Console.Write(" " + town);
            }

            //Тези двете отдолу са еквивалентни.
            var words = "Hello";

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
            }
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int nx = int.Parse(Console.ReadLine());                             //демонстриране на оператора "break". Изчисляване на факториел от зададено число.
            decimal factorial = 1;
            while (true)
            {
                if (nx <= 1)
                {
                    break;
                }
                factorial *= nx;
                nx--;
            }
            Console.WriteLine("n! = " + factorial);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int nz = int.Parse(Console.ReadLine());                             //Употреба на оператора "Continue".
            int sum = 0;
            for (int ii = 1; ii <= nz; ii += 2)
            {
                if (ii % 7 == 0)
                {
                    continue;                                                   //Когато сработи continue, се пропуска следващата част от цикъла (sum += ii;).
                }
                sum += ii;
            }
            Console.WriteLine("sum = " + sum);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
