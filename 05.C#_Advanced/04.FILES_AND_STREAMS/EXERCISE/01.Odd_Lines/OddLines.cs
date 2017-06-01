namespace _01.Odd_Lines
{
    using System;
    using System.IO;


    public class OddLines
    {
        public static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
