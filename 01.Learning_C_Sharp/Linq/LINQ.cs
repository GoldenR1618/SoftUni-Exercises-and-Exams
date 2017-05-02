using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class LINQ
    {
        static void Main(string[] args)
        {
            //Reverce() - Обръща реда на елементите в една колекция.
            //Concat() - съединява елементите на две колекции.

            //Min() – Finds the smallest element in a collection
            //Max() – Finds the largest element in a collection
            //Sum() – Finds the sum of all elements in a collection
            //Average() – Finds the average of all elements in a collection

            //ToArray() - to convert in Array
            //ToList() - to convert in List
            //ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary
            //ToCharArray()  - to convert in CharArray

            //Select() - using to read collections - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.

            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending - using to sort collections descending
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending

            //Take() - взима само първите N от колекцията.
            //Skip() - пропуска първите N от колекцията.

            //Where() - връща само тези, които отговарят на условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.

            //Distinct() - дава уникални числа. Ако се повтаря, ги пропуска.

            //First() - връща първото отговарящо на условието в скобите.
            //Last() - връща последното отговарящо на условието в скобите.
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.

            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 

            //EndsWith("") - проверява края на стринга дали съвпада с този в скобите и връща булл. Налага се да ползваме ToDictionary() след това за да го конвертираме в речник, защото var-а се пълни с булени.

            //Substring(start index, length) - връща определен брой символи от един стринг.
            //Replace() - замяна на символи в един стринг - Replace(" ", String.Empty) - истриване на интервалите в един стринг.

            //TryParse() - ако стойноста е от приемлив тип, се записва в out-a.
            /*  int number = 0;
                bool parsed = int.TryParse(Console.ReadLine(), out number);     */

            //IndexOf() - намира конкретен символ в текст и връща неговият индекс. - IndexOf('=')
            //LastIndexOf() - намира последният посочен символ в текст и връща неговият индекс. - LastIndexOf('=')
        }
    }
}
