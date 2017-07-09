namespace _03.Parse_Tags
{
    using System;

    public class ParseTags
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndex = input.IndexOf("<upcase>");
            int endIndex = input.IndexOf("</upcase>");

            while (startIndex != -1 && endIndex != -1)
            {
                string textToUp = input.Substring(startIndex + 8, endIndex - (startIndex + 8));

                input = input.Replace(textToUp, textToUp.ToUpper());
                input = input.Remove(endIndex, 9);
                input = input.Remove(startIndex, 8);

                startIndex = input.IndexOf("<upcase>");
                endIndex = input.IndexOf("</upcase>");
            }

            Console.WriteLine(input);
        }
    }
}
