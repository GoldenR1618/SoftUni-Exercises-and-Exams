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
            //EndsWith - проверява края на стринга дали съвпада с този в скобите и връща булл. Налага се да ползваме ToDictionary() след това за да го конвертираме в речник, защото var-а се пълни с булени.
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
            //Replace - замяна на символи в един стринг - Replace(" ", String.Empty) - истриване на интервалите в един стринг.
            //Split
            //StartsWith - съобщава дали стринга започва със зададения низ.
            //Substring - Substring(start index, length) - връща определен брой символи от един стринг.
            //ToCharArray  - to convert in CharArray.
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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max() – Finds the largest element in a collection.
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max
            //Max() – Finds the largest element in a collection.
            //Min
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max
            //Max() – Finds the largest element in a collection.
            //Min
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max() – Finds the largest element in a collection.
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max
            //Max() – Finds the largest element in a collection.
            //Min
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
            //All() - проверява дали всички елементи отговарят на условието в скобите.
            //Any() - проверява дали има някой елемент отговарящ на условието в скобите.
            //AsEnumerable()
            //AsParallel
            //AsParallel()
            //AsQueryable
            //AsQueryable()
            //Average
            //Average() – Finds the average of all elements in a collection.
            //Cast()
            //Concat() - съединява елементите на две колекции.
            //Contains() - съобщава дали съдържа подаденото в скобите.
            //Count() - връща броя на тези, които отговарят на условие - Count(num => num % 2 == 0) - връща БРОЯ на четните.
            //DefaultIfEmpty()
            //Distinct() - дава уникални елементи. Ако се повтарят, ги пропуска.
            //ElementAt()
            //ElementAtOrDefault()
            //Except()
            //First() - връща първото отговарящо на условието в скобите.
            //FirstOrDefault() - връща първото отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ.
            //GroupJoin()
            //Intersect()
            //Join()
            //Last() - връща последното отговарящо на условието в скобите.
            //LastOrDefault() - връща последното отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //LongCount()
            //Max() – Finds the largest element in a collection.
            //Min() – Finds the smallest element in a collection.
            //OfType()
            //OrderBy() - using to sort collections OrderBy(x => x), OrderBy(x => x.Value) - сортирай по стойност.
            //OrderByDescending() - using to sort collections descending.
            //ThenBy() - using to sort collections by more than 1 criteria OrderBy(x => x.Value).ThenBy(x => x.Key) - сортирай първо по стойност, после по ключ.
            //ThenByDescending() - using to sort collections by more than 1 criteria descending.
            //Reverse() - Обръща реда на елементите в една колекция.
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря.
            //SelectMany() - обединява множество колекции в една колекция.
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите.
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. 



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
