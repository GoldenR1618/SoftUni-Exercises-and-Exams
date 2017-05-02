namespace Таймер
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class Таймер
    {
        public static void Main(string[] args)
        {
            string result = "";
            Stopwatch st = new Stopwatch();

            st.Start();

            for (int i = 0; i < 50000; i++)
            {
                result += (Convert.ToString(i, 2) + "\n");
            }

            st.Stop();

            Console.WriteLine(st.Elapsed);
        }
    }
}