using System;

namespace Diamond
{
 class Program
   {
       static void Main()
       {
           int n = int.Parse(Console.ReadLine());
		   
           Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
           for (int k = n  - 1; k > 0; k--)
           {
               Console.WriteLine("{0}*{1}*{0}", new string('.', k), new string('.', ((5 * n - 2 - 2 * k))));
           }
           Console.WriteLine("{0}", new string('*', 5 * n));
           int i = 1;
           for (i = 1; i <= 2 * n; i++)
           {
               Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (5 * n - 2 - 2 * i)));
           }
           Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', (5 * n - 2 - 2 * i)));
       }
   } 
}
