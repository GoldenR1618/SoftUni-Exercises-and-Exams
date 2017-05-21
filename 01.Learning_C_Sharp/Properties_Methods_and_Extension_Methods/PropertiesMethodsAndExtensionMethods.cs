namespace Properties_Methods_and_Extension_Methods
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PropertiesMethodsAndExtensionMethods
    {
        public static void Main(string[] args)
        {
            //IEnumerable - всичко от този тип, можем само да foreach-ме и нищо друго. LINQ връща IEnumerable тип данни. За това след употреба завършваме с ToArray, ToList... освен ако не искаме само да го foreach за финал. 
            //ICollection - позволява освен да foreach-ме и: Add, Clear, Contains, CopyTo, Remove.

            //Min() – Finds the smallest element in a collection
            //Max() – Finds the largest element in a collection
            //Sum() – Finds the sum of all elements in a collection
            //Average() – Finds the average of all elements in a collection

            //ToArray() - to convert in Array
            //ToList() - to convert in List
            //ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary
            //ToCharArray()  - to convert in CharArray

            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending - using to sort collections descending
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending

            //Take() - взима само първите N от колекцията.
            //Skip() - пропуска първите N от колекцията.

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







            /////////////////////////////////////////////
            // int, long, float, double, bool, decimal //
            /////////////////////////////////////////////

            //Methods:
            //CompareTo
            //Equals
            //GetHashCode
            //GetType
            //GetTypeCode
            //ToString



            //////////////////////
            //      string      //
            //////////////////////

            //Properties:
            //Length
            
            //Methods:
            //Clone
            //CompareTo
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //EndsWith
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetType
            //GetTypeCode
            //IndexOf - намира конкретен символ в текст и връща неговият индекс. - IndexOf('=')
            //IndexOfAny
            //Insert
            //IsNormalized
            //LastIndexOf - намира последният посочен символ в текст и връща неговият индекс. - LastIndexOf('=')
            //LastIndexOfAny
            //Normalize
            //PadLeft
            //PadRight
            //Remove
            //Replace
            //Split
            //StartsWith - съобщава дали стринга започва със зададения низ.
            //Substring
            //ToCharArray
            //ToLower
            //ToLowerInvariant
            //ToString
            //ToUpper
            //ToUpperInvariant
            //Trim
            //TrimEnd
            //TrimStart

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max()
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip()



            //////////////////////
            //      Array       //
            //////////////////////

            //Properties:
            //IsFixedSize
            //IsReadOnly
            //IsSynchronized
            //Length
            //LongLength
            //Rank
            //SyncRoot

            //Methods:
            //Clone
            //CopyTo
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetLength
            //GetLongLength
            //GetLowerBound
            //GetType
            //GetUpperBound
            //GetValue
            //Initialize
            //SetValue
            //ToString

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max
            //Max()
            //Min
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip()



            //////////////////////
            //       List       //
            //////////////////////

            //Properties:
            //Capacity
            //Count

            //Methods:
            //Add
            //AddRange
            //AsReadOnly
            //BinarySearch
            //Clear
            //Contains - съобщава дали съдържа подаденото в скобите.
            //ConvertAll()
            //CopyTo
            //Equals
            //Exists
            //Find
            //FindAll
            //FindIndex
            //FindLast
            //FindLastIndex
            //ForEach
            //GetEnumerator
            //GetHashCode
            //GetRange
            //GetType
            //IndexOf - намира конкретен символ в текст и връща неговият индекс. - IndexOf('=')
            //Insert
            //InsertRange
            //LastIndexOf - намира последният посочен символ в текст и връща неговият индекс. - LastIndexOf('=')
            //Remove
            //RemoveAll
            //RemoveAt
            //RemoveRange
            //Reverse - Обръща реда на елементите в една колекция.
            //Sort
            //ToArray
            //ToString
            //TrimExcess
            //TrueForAll

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max
            //Max()
            //Min
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip()   



            //////////////////////////////////
            // Dictionary, SortedDictionary //
            //////////////////////////////////

            //Properties:
            //Comparer
            //Count
            //Keys
            //Values

            //Methods:
            //Add
            //Clear
            //ContainsKey
            //ContainsValue
            //CopyTo +SortedDictionary
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetObjectData -SortedDictionary
            //GetType
            //OnDeserialization -SortedDictionary
            //Remove
            //ToString
            //TryGetValue

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max()
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip()



            //////////////////////
            //     HashSet      //
            //////////////////////

            //Properties:
            //Comparer
            //Count

            //Methods:
            //Add
            //Clear
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Equals
            //ExceptWith
            //GetEnumerator
            //GetHashCode
            //GetObjectData
            //GetType
            //IntersectWith
            //IsProperSubsetOf
            //IsProperSupersetOf
            //IsSubsetOf
            //IsSupersetOf
            //OnDeserialization
            //Overlaps
            //Remove
            //RemoveWhere
            //SetEquals
            //SymmetricExceptWith
            //ToString
            //TrimExcess
            //UnionWith

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max
            //Max()
            //Min
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() 



            //////////////////////
            //    SortedSet     //
            //////////////////////

            //Properties:
            //Comparer
            //Count
            //Max
            //Min

            //Methods:
            //Add
            //Clear
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Equals
            //ExceptWith
            //GetEnumerator
            //GetHashCode
            //GetType
            //GetViewBetween
            //IntersectWith
            //IsProperSubsetOf
            //IsProperSupersetOf
            //IsSubsetOf
            //IsSupersetOf
            //Overlaps
            //Remove
            //RemoveWhere
            //Reverse - Обръща реда на елементите в една колекция.
            //SetEquals
            //SymmetricExceptWith
            //ToString
            //UnionWith

            //Extension Methods:
            //Aggregate()
            //All()
            //Any()
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average()
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count()
            //DefaultIfEmpty()
            //Distinct()
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First()
            //FirstOrDefault()
            //GroupBy()
            //GroupJoin()
            //Intersect()
            //Join()
            //Last()
            //LastOrDefault()
            //LongCount()
            //Max()
            //Min()
            //OfType()
            //OrderBy()
            //OrderByDescending()
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany()
            //SequenceEqual()
            //Single()
            //SingleOrDefault()
            //Skip()
            //SkipWhile()
            //Sum
            //Sum()
            //Take()
            //TakeWhile()
            //ToArray()
            //ToDictionary()
            //ToList()
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() 



            //////////////////////
            //      Stack       //
            //////////////////////

            //Properties:
            //Count

            //Methods:
            //Clear
            //Clone
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetType
            //Peek
            //Pop
            //Push
            //ToArray
            //ToString

            //Extension Methods:
            //AsParallel
            //AsQueryable
            //Cast()
            //OfType()



            //////////////////////
            //       Queue      //
            //////////////////////

            //Properties:
            //Count

            //Methods:
            //Clear
            //Clone
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Dequeue
            //Enqueue
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetType
            //Peek
            //ToArray
            //ToString
            //TrimToSize

            //Extension Methods:
            //AsParallel
            //AsQueryable
            //Cast()
            //OfType()

            //////////////////////
            //      Matrics     //
            //////////////////////

            //Properties:

            //Methods:

            //Extension Methods:
        }
    }
}
