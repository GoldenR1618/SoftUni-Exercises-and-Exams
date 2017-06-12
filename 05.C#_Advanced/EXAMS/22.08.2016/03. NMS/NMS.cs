namespace _03.NMS
{
    using System;
    using System.Text;

    public class NMS
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (input != "---NMS SEND---")
            {
                sb.Append(input);
                
                input = Console.ReadLine();
            }

            string delimiter = Console.ReadLine();

            string text = sb.ToString();

            StringBuilder output = new StringBuilder();
            output.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                char preview = text[i - 1];
                char next = text[i];

                if (string.Compare(preview.ToString(), next.ToString(), true) <= 0)
                {
                    output.Append(next);
                }
                else
                {
                    output.Append(delimiter);
                    output.Append(next);
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
