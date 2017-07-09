namespace Functional_Programming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class FunctionalProgramming
    {
        public static void Main(string[] args)
        {
            //Implicit lambda expression: msg => Console.WriteLine(msg);
            //Explicit lambda expression: (String msg) => { Console.WriteLine(msg); }
            //Zero parameters: () => { Console.WriteLine("hi"); }
            //More parameters: (int x, int y) => { return x + y; }
            


            //Instead of writing the method we can do:
            Action<string> print = message => Console.WriteLine(message);   //In .NET Action<T> is a void method.

            //Then we use it like that:
            print("pesho");
            print(5.ToString());



            //We can use Func<T, TResult>
            //In.NET Func<T, TResult> is a method that returns type TResult
            Func<int, int> increment = number => number + 1;    //Последният ТИП в <> указва типа данни който ВРЪЩАМЕ.
            int a = increment(5);
            int b = increment(a);



            //1. We can use the method like that:
            int c = 5;
            int d = Operation(c, n => n * 5);
            int e = Operation(c, n => n - 3);
            int f = Operation(d, n => n % 2);



            //2. We can filter collections using Func<T>:
            List<int> list = new List<int> { 2, 5, -4, -1, 54, 4 };
            List<int> evenNums = Filter(list, num => num % 2 == 0); //Все едно ползваме var evenNums = list.Where(num => num % 2 == 0).



            //3. We can filter collections using extension collection and Func<T>:
            List<int> list2 = new List<int> { 2, 5, -4, -1, 54, 4 };
            List<int> evenNums2 = list2.ExtFilter(num => num % 2 == 0);



            //Разлика между Func и Expression. Func може да бъде извикан. Expression не. Func е делегат (променлива която държи фукнция). Expression-а съдържа информация за кода, който е описан във вункцията.
            Func<int> myFunc = () => 1; //Не приема параметри и връща 1.
            Expression<Func<int>> myExpr = () => 1;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //1. We can pass Func<T> to methods:
        public static int Operation(int number, Func<int, int> operation)
        {
            return operation(number);
        }

        //2. We can filter collections using Func<T>:
        public static List<int> Filter(List<int> list, Func<int, bool> filter)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public static class CollectionExtensions
    {
        //3. We can filter collections using extension collection and Func<T>:
        public static List<int> ExtFilter(this List<int> list, Func<int, bool> filter)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }

        //Направа на foreach функция, която работи със ВСИЧКИ колекции, дори и тези, които нямат foreach.
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }

            return collection;
        }
    }
}
