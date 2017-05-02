namespace Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Strings
    {
        public static void Main(string[] args)
        {
            //Case-insensitive
            int result = string.Compare("aaa", "bbb", true);
            // result == 0 if str1 equals str2
            // result < 0 if str1 is before str2
            // result > 0 if str1 is after str2

            //Case-sensitive
            int result2 = string.Compare("Aaa", "bbb", false);

            //Case-sensitive comparison
            if ("aaa" == "bbb")
            {

            }

            //Case-sensitive Equals() method
            if ("aaa".Equals("bbb"))
            {

            }

            //Using the Concat() method
            string str = string.Concat("aaa", "bbb");

            //Using the + or the += operators
            string str2 = "aaa" + "bbb" + "ccc";
            str2 += str;

            //str.IndexOf(string term) – returns the index of the first occurrence of term in str
            string email = "vasko@gmail.org";
            int firstIndex = email.IndexOf("@"); // 5
            int noIndex = email.IndexOf("/"); // -1

            //str.LastIndexOf(string term) – returns the index of the last occurrence of term in str
            string verse = "To be or not to be..";
            int lastIndex = verse.LastIndexOf("be"); // 16

            //str.IndexOf(string term, start index) - задаваме стартовият индекс от който да започне да търси.

            //Програма за сравнение на стринг и патерн.
            string input = Console.ReadLine().ToLower();    //aaaaaa
            string patern = Console.ReadLine().ToLower();   //aa

            int counter = 0;

            int index = input.IndexOf(patern);

            while (index != -1)     //Ако няма съвпадение между патерна и текста, IndexOf връща -1.
            {
                counter++;
                index = input.IndexOf(patern, index + 1);   //index + 1 - стартовив индекс от където да започне сравнението.
            }

            Console.WriteLine(counter); //5

            //Extracting substrings

            //str.Substring(int startIndex, int length)
            string filename = @"C:\Pics\Rila2005.jpg";
            string name = filename.Substring(8, 8); //Първата цифра е стартовиеят индекс, втората е дължината.
            //name is Rila2005
            int index2 = int.Parse(Console.ReadLine());
            string name2 = filename.Substring(index2, filename.Length - index -5); //Когато индекса се подава от вън, а оскаме да отпечатаме от индекса до 5 преди края.

            //str.Substring(int startIndex)
            string filename2 = @"C:\Pics\Summer2009.jpg";
            string nameAndExtension = filename2.Substring(8);
            //nameAndExtension is Summer2009.jpg

            //Splitting Strings
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(' ', ',', '.');

            //Replacing Substrings. str.Replace(string match, string term) – replaces all occurrences of given string with another
            string cocktail = "Vodka + Martini + Cherry";
            string replaced = cocktail.Replace("+", "and");     // Vodka and Martini and Cherry

            //Deleting Substrings. str.Remove(int index, int length) – deletes part of a string and produces a new string as result
            string price = "$ 1234567";
            string lowPrice = price.Remove(2, 3); //$ 4567

            //ToLower()
            string alpha = "aBcDeFg";
            string lowerAlpha = alpha.ToLower(); // abcdefg

            //ToUpper()
            string alpha1 = "aBcDeFg";
            string upperAlpha1 = alpha1.ToUpper(); // ABCDEFG

            //str.Trim() – trims whitespaces at start and end of string
            string s = "    example of white space    ";
            string clean = s.Trim();    //example of white space

            //str.Trim(params char[] chars) - но пак подрязва само в началото и края текста. Не може вътре в текста да реже.
            string s1 = " \t\nHello!!! \n";
            string clean1 = s1.Trim(' ', ',', '!', '\n', '\t');     //Hello

            //str.TrimStart() and str.TrimEnd() - едното реже в началото. Другото в края.
            string s3 = "   C#   ";
            string clean3 = s3.TrimStart(); //clean = "C#   ";

            //StringBuilder - keeps a buffer memory, allocated in advance.
            //Use StringBuilder if you need to keep adding characters to a string.
            //StringBuilder(int capacity) constructor allocates in advance buffer of size capacity
            //.Capacity - holds the currently allocated space (in characters)
            //this[int index] (indexer in C#) gives access to the char value at given position
            //.Length - holds the length of the string in the buffer
            //.Append(…) - appends a string or another object after the last character in the buffer
            //.Remove(int startIndex, int length) - removes the characters in given range
            //.Insert(int index, string str) - inserts given string (or object) at given position
            //.Replace(string oldStr, string newStr) - replaces all occurrences of a substring
            //.ToString() - converts the StringBuilder to String
            //Програма за ревърс на символите в един стринг.
            string input2 = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = input2.Length - 1; i >= 0; i--)
            {
                sb.Append(input2[i]);
            }
            
            Console.WriteLine(sb.ToString()); 
        }
    }
}
