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
            int n = 5;
            long l = 1000000000;
            float f = 1.05f;
            double d = 5.045;
            bool b = true;
            decimal m = 0.005m;

            //Methods:
            //CompareTo - Сравняване на два стринга. int result = str1.CompareTo(str2). result == 0 if str1 equals str2, result < 0 if str1 is before str2, result > 0 if str1 is after str2.
            //Equals
            //GetHashCode
            //GetType
            //GetTypeCode
            //ToString



            //////////////////////
            //      string      //
            //////////////////////
            string s = "text";

            //Properties:
            //Length - показва дължината на стринга.

            //Methods:
            //Clone
            //CompareTo - Сравняване на два стринга. int result = str1.CompareTo(str2). result == 0 if str1 equals str2, result < 0 if str1 is before str2, result > 0 if str1 is after str2.
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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - Съединяване на две колекции по някакви критерии. var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result)); 
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //      Array       //
            //////////////////////
            int[] arr = new int[5];

            //Properties:
            //IsFixedSize
            //IsReadOnly
            //IsSynchronized
            //Length - показва дължината на масива.
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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //       List       //
            //////////////////////
            List<int> list = new List<int>();

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
            //ForEach - void функция аналогична на нормалния foreach. list.Where(x => x > 2).ToList().ForEach(x => Console.WriteLine(x));
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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////////////////
            // Dictionary, SortedDictionary //
            //////////////////////////////////
            Dictionary<string, int> dict = new Dictionary<string, int>();

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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //     HashSet      //
            //////////////////////
            HashSet<int> hash = new HashSet<int>();

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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary( - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //    SortedSet     //
            //////////////////////
            SortedSet<int> sort = new SortedSet<int>();

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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //      Stack       //
            //////////////////////
            Stack<int> stack = new Stack<int>();

            //Properties:
            //Count - показва броя на елементите в стека.

            //Methods:
            //Clear - изчиства стека.
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetType
            //Peek - Returns the last element from the stack without removing it.
            //Pop - Returns the last element from the stack.
            //Push - Adds an element on top of the Stack.
            //ToArray
            //ToString
            //TrimExcess - Resize the internal array.

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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //       Queue      //
            //////////////////////
            Queue<int> qu = new Queue<int>();

            //Properties:
            //Count

            //Methods:
            //Clear - Remove all elements.
            //Contains - съобщава дали съдържа подаденото в скобите.
            //CopyTo
            //Dequeue - Returns the first element from the queue and removes it.
            //Enqueue - Adds an element to the front of the queue.
            //Equals
            //GetEnumerator
            //GetHashCode
            //GetType
            //Peek - Returns the first element from the queue without removing it.
            //ToArray
            //ToString
            //TrimExcess - Resize the internal array.

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
            //GroupBy() - Трансформира колекция в групи. Всяка група си има ключ. var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key); foreach (var group in groups) { Console.WriteLine(group.Key + " - " + string.Join(", ", group)); }. Ако в скобите липсва втори аргумент, добавя целият обект, иначе добавя към групата само посоченият елемент.
            //GroupJoin() - It groups one collection of objects by a key and joins those groups with another collection of keyed objects. With this method, we create a collection where, at each key, a group of results is placed.
            //Intersect()
            //Join() - var arr1 = new int[3] { 1, 25, 300 }; var arr2 = new int[3] { 2, 26, 301 }; var result = arr1.Join(arr2, x => x + 1, y => y, (x, y) => x); /*Избери елемент X от arr1 ако в arr2 има X+1.*/ Console.WriteLine(string.Join(" ", result));
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
            //Select() - Конвертира данните в друг тип - Select(x => x *2) - връща всички цифри от списъка в нов списък умножени по 2. Select(x => (char)(x + 'a' - 1)) - на всички цифри, коя буква отговаря. Select(student => new { FullName = student.FirstName + " " + student.LastName}) - правене на нов обект.
            //SelectMany() - обединява множество колекции в една колекция. List<int[]> list = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 } }; int[] result = list.SelectMany(n => n).ToArray(); Console.WriteLine(string.Join(" ", result));
            //SequenceEqual()
            //Single() - връща само ако има единствено число отговарящо на условието в скобите. Ако има повече от едно - гърми!!!
            //SingleOrDefault() - връща само ако има единствено число отговарящо на условието в скобите. Ако не се изпълнява това условие, връща дефолтна стойност.
            //Skip() - пропуска първите N елементи от колекцията.
            //SkipWhile()
            //Sum
            //Sum() – Finds the sum of all elements in a collection.
            //Take() - взима само първите N елемента от колекцията.
            //TakeWhile()
            //ToArray
            //ToArray() - to convert in Array.
            //ToDictionary() - ToDictionary(x => x.Key, x => x.Value) - to convert in Dictionary. Ако не посочим Value-то, ще използва за Value целият обект. Пример: Dictionary<bool, List<int>> dict = arr.GroupBy(num => num % 2 ==  0).ToDictionary(g => g.Key, g => g.ToList()); - Ако не ToList-ем Value-то, няма да можем да го достъпваме директно елемент по елемент.
            //ToList() - to convert in List.
            //ToLookup()
            //ToString
            //TrimExcess
            //Union()
            //Where() - търси в колекция по зададено условие - Where(num => num % 2 == 0) - връща САМО четните.
            //Zip() - взима две колекции и изпълнява с тях условието в скобите - var result = first.Zip(second, (x, y) => (x + y)) - сумира елемент на първата със съответният елемент на втората. int[] arr = new int[] { 1, 2, 3 }; int[] arr2 = new int[] { 5, 4, 3 }; int[] result = arr.Zip(arr2, (a, b) => (a + b)).ToArray(); Console.WriteLine(string.Join(" ", result));



            //////////////////////
            //      Matrics     //
            //////////////////////

            //Properties:

            //Methods:

            //Extension Methods:
        }
    }
}
