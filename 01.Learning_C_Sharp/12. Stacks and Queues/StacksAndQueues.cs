namespace Stacks_and_Queues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StacksAndQueues
    {
        public static void Main(string[] args)
        {
            //Push - Adds an element on top of the Stack.
            //Pop - Returns the last element from the stack.
            //Peek - Returns the last element from the stack without removing it.

            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>(12);    //Specified initial capacity of internal array.

            //Copied elements from the specified collection and remains their order.
            string[] values = { "Advanced", "OOP", "OOP Advanced" };
            Stack<string> st3 = new Stack<string>(values);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Enqueue - Adds an element to the front of the queue.
            //Dequeue - Returns the first element from the queue and removes it.
            //Peek - Returns the first element from the queue without removing it.

            Queue<int> qu = new Queue<int>();
        }
    }
}
