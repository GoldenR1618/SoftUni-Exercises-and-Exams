namespace Patterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Patterns
    {
        public static void Main()
        {
            //Design Patterns:
            //  General repeatable solution to a commonly occurring problem in software design.
            //  Providing tested, proven development paradigms.
            //  Improves code readability for developers already familiar with the patterns.
        }
    }

    //Iterator Pattern:
    //...



    //Strategy Pattern:
    //Encapsulates an algorithm inside a class.
    //  Making each algorithm replaceable by others.
    //  All the algorithms can work with the same data transparently.
    //  The client can work with each algorithm transparently.
    public interface ISortStrategy
    {
        void Sort(IList<object> list);
    }

    public class QuickSort : ISortStrategy
    {
        public void Sort(IList<object> list)
        {
            // Some sorting logic...
        }
    }

    public class MergeSort : ISortStrategy
    {
        public void Sort(IList<object> list)
        {
            // Some sorting logic...
        }
    }

    public class SortedList
    {
        private IList<object> list = new List<object>();

        public void Sort(ISortStrategy sortStrategy)    //sortStrategy can be passed in constructor or like method parameter.
        {
            sortStrategy.Sort(list);
        }
    }
}
