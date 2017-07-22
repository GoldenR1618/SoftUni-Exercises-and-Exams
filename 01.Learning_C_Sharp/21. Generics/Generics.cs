namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Generics
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove()); 
        }

        //Generic Constraints:
        public void MyMethod<T>() where T : class
        {
            //class - specifying the type to be a reference type.
            //struct - specifying the type to be a value type.
            //new () - specifying a constructor as a constrain. Only a default constructor can be used in the constraints.
            //BaseClass - specifying a static base class as a constraint. The type argument must be or derive from the specified base class.
        }

        public void MyMethod<T, U>() where T : U
        {
            //U - Specifying a generic base class as a constraint. The type argument supplied for T must be or derive from the argument supplied for U.
        }
    }

    public interface IBox<T>                //Можем да направим и интерфейс.
    {
        int Count { get; }

        void Add(T element);

        T Remove();
    }

    //Generics Classes:
    public class Box<T> : IBox<T>           //Defined with <Type Parameter>
    {
        private IList<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var rem = this.data.LastOrDefault();
            this.data.RemoveAt(this.data.Count - 1);
            return rem;
        }
    }

    public class Dictionary<TKey, TValue>   //Defined with multiple Type Parameters
    {

    }

    public static class CollectionExtensions
    {
        //Generic Methods:
        //Can take generic input and return generic output
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
