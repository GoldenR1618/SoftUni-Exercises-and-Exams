namespace Strings_and_Text_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringsAndTextProcessing
    {
        public static void Main(string[] args)
        {
            //Форматиране на текст:
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("{0:0.00}", 1);                   //Output: 1,00    
            Console.WriteLine("{0:#.##}", 0.234);               //Output: ,23    
            Console.WriteLine("{0:#####}", 12345.67);           //Output: 12346    
            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);  //Output: (02) 934 25 25    
            Console.WriteLine("{0:%##}", 0.234);                //Output: %23  
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("{0:C2}", 123.456);               //Output: 123,46 лв.    
            Console.WriteLine("{0:D6}", -1234);                 //Output: -001234
            Console.WriteLine("{0:E2}", 123);                   //Output: 1,23Е+002    
            Console.WriteLine("{0:F2}", -123.456);              //Output: -123,46    
            Console.WriteLine("{0:N2}", 1234567.8);             //Output: 1 234 567,80    
            Console.WriteLine("{0:P}", 0.456);                  //Output: 45,60%    
            Console.WriteLine("{0:X}", 254);                    //Output: FE    
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("{0,6}", 123);                    //6 означава броя позиции в които да се падва стринга в дясно.
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.WriteLine("{0,-6}", 12);                    //-6 падва стринга в ляво.
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("{0:G}", DayOfWeek.Wednesday);    //Представя енумерацията като стринг (Wednesday).
            Console.WriteLine("{0:D}", DayOfWeek.Wednesday);    //Представя енумерацията като число (3).
            Console.WriteLine("{0:X}", DayOfWeek.Wednesday);    //Представя енумерацията като число в шестнадесетичната бройна система и с осем цифри (00000003).
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //string.Format() provides a format language to which we add variables.
            //string.Format("{0:f3}“, number); - Insert  and format double numbers.
            //string.Format("{0:X}“, number); - Insert and convert to HEX value.
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //Insert DateTime
            string value = string.Format("It is now {0:d} at {0:t}", DateTime.Now); //It is now 4/10/2016 at 10:04 AM
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

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
            string name2 = filename.Substring(index2, filename.Length - index - 5); //Когато индекса се подава от вън, а оскаме да отпечатаме от индекса до 5 преди края.

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

            //str.PadLeft(int totalWidth, char symbol) – adds symbols at the begging.
            string s4 = "Ana";
            string padded = s4.PadLeft(5, ' ');
            Console.WriteLine(padded); // '   Ana' 

            //str.PadRight(int totalWidth, char symbol) – adds symbols at the end.
            string s5 = "Ana";
            string padded2 = s5.PadRight(5, ' ');
            Console.WriteLine(padded2); // 'Ana   ' 

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
