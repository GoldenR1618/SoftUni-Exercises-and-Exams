namespace Iterators_and_Comparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IteratorsAndComparators
    {
        public static void Main()
        {
            //Yield Return
            //Indicates that the member in which it appears is an iterator
            //Simplifies the IEnumerator<T> implementations
            //Returns one element upon each loop cycle



            PrintNames("Pesho", "Stamat", "Jivko", "Stavri");



            IComparer<Cat> comparer = new CatComparer();
            SortedSet<Cat> catsByName = new SortedSet<Cat>(comparer);   //Подаваме направеният от нас компаратор в конструктора.
        }



        //Params
        //Takes a variable number of arguments
        //Only one params keyword is allowed in a method declaration
        //Should always be last
        public static void PrintNames(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }



    //IEnumerable<T>
    //Root interface of .NET, enables simple iteration over a collection
    //Contains a single method GetEnumerator(), which returns an IEnumerator<T>
    //A class that implements the IEnumerable<T> can be used in a foreach loop traversal
    public interface IEnumerable<T> : IEnumerable
    {
        IEnumerator<T> GetEnumerator();
    }

    // Non-generic version (compatible with the legacy .NET 1.1)
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }



    //IEnumerator<T>
    //Provides the sequential, forward - only iteration over a collection of any type
    //Methods:
    //MoveNext() - advances the enumerator to the next element of the collection.
    //Reset() - sets the enumerator to its initial position
    //Properties:
    //Current – returns the element in the collection at the current position of the enumerator
    public interface IEnumerator<T> : IEnumerator
    {
        bool MoveNext();

        void Reset();

        T Current { get; }
    }

    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }



    //IComparable<T>
    //Reads out as “I am Comparable”
    //Provides a method of comparing two objects of a particular type – CompareTo()
    //Sets a default sort order for the particular objects type
    //Affects original class
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point otherPoint)
        {
            if (this.X != otherPoint.X)
            {
                return (this.X - otherPoint.X);
            }

            if (this.Y != otherPoint.Y)
            {
                return (this.Y - otherPoint.Y);
            }

            return 0;
        }
    }

    public class Cat : IComparable<Cat>
    {
        public string Name { get; set; }

        public int CompareTo(Cat other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }



    //IComparer<T>
    //Reads out as “I Compare”
    //Provides a way to customize the sort order of a collection
    //Defines a method that a type implements to compare two objects
    //Doesn’t affect original class
    public class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
