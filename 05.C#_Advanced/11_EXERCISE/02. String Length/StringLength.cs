namespace _02.String_Length
{
    using System;

    public class StringLength
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MaxTwentyChars(Console.ReadLine()));
        }

        private static string MaxTwentyChars(string v)
        {
            if (v.Length <= 20)
            {
                return v.PadRight(20, '*');
            }
            else
            {
                return v.Substring(0, 20);
            }
            
        }
    }
}
