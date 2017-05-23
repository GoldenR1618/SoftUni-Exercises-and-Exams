namespace _05_Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;

    public class SequenceWithQueue
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> seq = new Queue<long>();

            Console.Write($"{n} ");
            seq.Enqueue(n);
            int count = 1;

            while (count < 50)
            {
                n = seq.Dequeue();

                long s1 = n + 1;
                Console.Write($"{s1} ");
                seq.Enqueue(s1);
                count++;

                if (count >= 50)
                {
                    break;
                }

                long s2 = 2 * n + 1;
                Console.Write($"{s2} ");
                seq.Enqueue(s2);
                count++;

                if (count >= 50)
                {
                    break;
                }

                long s3 = n + 2;
                Console.Write($"{s3} ");
                seq.Enqueue(s3);
                count++;
            }
        }
    }
}
