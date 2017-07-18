namespace _02_Index_of_Letters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class IndexofLetters
    {
        public static void Main(string[] args)
        {
            string input = File.ReadAllText("input2.txt");

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < input.Length; i++)
            {
                for (int r = 0; r < alphabet.Length; r++)
                {
                    if (input[i] == alphabet[r])
                    {
                        File.AppendAllText("output2.txt", $"{input[i]} -> {r}{Environment.NewLine}");
                    }
                }
            }
        }
    }
}
