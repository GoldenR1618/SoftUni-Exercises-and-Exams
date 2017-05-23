namespace Regex_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class RegexDemo
    {
        public static void Main(string[] args)
        {
            //Character Classes
            //[abc] matches any character that is either a, b or c
            //[^abc] – matches any character that is not a, b or c
            //[0-9] - Character range: Мatches any digit frm 0 to 9
            //[a|b] - a или b.

            //\w – Matches any word character (a-z, A-Z, 0-9, _)
            //\W – Matches any non - word character(the opposite of \w)
            //\s – Matches any white - space character
            //\S – Matches any non - white - space character(opposite of \s)
            //\d – Matches any decimal digit
            //\D – Matches any non - decimal digit(opposite of \d)
            //\b - задава граница на стринга - \b[a-zA-Z][a-zA-Z0-9_]{2,24}\b

            //\t - tab
            //\n - new line
            //\+ - + - escape +
            //\* - * - escape * 
            //\? - ? - escape ?



            //Quantifiers
            //* - Matches the previous element zero or more times
            //+ - Matches the previous element one or more times
            //? - Matches the previous element zero or one time



            //Anchors
            //^ -The match must start at the beginning of the string or line
            //$ -The match must occur at the end of the string
            //Пример - ^\w{6,12}$ - user name validation - Започваш с дума от 6 до 12 символа и завършваш само с това. Нищо след нея няма.
            //{6,12} - от 6 до 12. {6,} - минимум 6 символа. {6} - точно 6 символа.

            //  \d\s\d{3}s\d{3}-\d{3}   - валидиране на 0 878 123-456       - {3,} - ПОНЕ 3 СИМВОЛА! - {3, 6} - от 3 до 6 символа
            //                (-|\/)    - валидираме и "/" освен "-" като символ. С тази "\" ескейпваме.



            //Grouping Constructs
            //(subexpression) - captures the matched subexpression and assigns it a number
            //\d{2}-(\w{3})-\d{4} => 22-Jan-2015 - запазва Jan под номер 1
            //(?<name>subexpression) - Captures the matched subexpression into a named group
            //(?:subexpression) – Defines a non-capturing group - дефинира група, която НЕ СЕ прихваща.
            //^(?:Hi|hello),\s*(\w+)$ => Hi, Peter - мачва Peter.



            //Backreference Constructs - извикване на дефинирани групи
            //\number – matches the value of a numbered subexpression. Извикване вътре в реджекса, номера на дефинирана група (преизползване на група).
            //\d{2}(-|\/)\d{2}\1\d{4} => мачва 22-12-2015 или 05/08/2016 - \1 извиква група 1
            //\k<name> – matches the value of a named expression - можем да именоваме групите
            //\d{2}(?<del>-|\/)\d{2}\k<del>\d{4} => мачва 22-12-2015 или 05/08/2016 - ?<del> - именоване на група - \k<del> извикване на именована група



            //Positive and Negative Lookahead
            //Negative Lookahead - a(?!b) - Match "a" if not followed by a "b".
            //Positive Lookahead - a(?=b) - Match "a" if followed by a "b".



            //Positive and Negative Lookbehind
            //Negative Lookbehind - (?<!b)a - Match "a" if not preceded by a "b".
            //Positive Lookbehind - (?<=b)a - Match "a" if preceded by a "b".



            //.*? - хва]a всичко до първияt срещнат препинателен знак.
            //\btext\b - word boundary.



            //Regex in VS -> using System.Text.RegularExpressions 
            string text2 = "Today is 2015-05-11";
            string pattern2 = @"\d{4}-\d{2}-\d{2}";
            //IsMatch(string text) – determines whether the text matches the pattern
            Regex regex2 = new Regex(pattern2);
            bool containsValidDate = regex2.IsMatch(text2);
            Console.WriteLine(containsValidDate); // True



            //Checking for a Single Match
            //Match(string text) – returns the first match that corresponds to the pattern
            string text = "Nakov: 123";
            string pattern = @"([A-Z][a-z]+): (\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);
            Console.WriteLine(match.Groups.Count); // 3
            Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]);
            Console.WriteLine("Name: {0}", match.Groups[1]); // Nakov
            Console.WriteLine("Number: {0}", match.Groups[2]); // 123
            //0 - целият текст. 1 - първа обособена група. 2 - втора...



            //Matches(string text) – returns a collection of matching strings that correspond to the pattern
            string text3 = "Nakov: 123, Branson: 456";
            string pattern3 = @"([A-Z][a-z]+): (\d+)";
            Regex regex3 = new Regex(pattern3);
            MatchCollection matches = regex3.Matches(text3);
            Console.WriteLine("Found {0} matches", matches.Count);
            foreach (Match match3 in matches)
            {
                Console.WriteLine("Name: {0}", match3.Groups[1]);   //Groups[0] - вади целите групи (Nakov: 123),
                                                                    //Group[1] - вади само първата група от съвпаденията (Nakov),
                                                                    //Group[2] - вади само втората група от съвпаденията (123)
            }
            // Found 2 matches
            // Name: Nakov
            // Name: Branson



            //Replacing With Regex
            //Replace(string text, string replacement) – replaces all strings that match the pattern with the provided replacement
            string text4 = "Nakov: 123, Branson: 456";
            string pattern4 = @"\d{3}";
            string replacement4 = "999";
            Regex regex4 = new Regex(pattern4);
            string result4 = regex4.Replace(text4, replacement4);
            Console.WriteLine(result4);
            // Nakov: 999, Branson: 999



            //Да се направи валидатор на мейли от типа: test_test@som.com, te@tes.te
            //\w{2,}@[A-Za-z0-9]{3,}\.[A-Za-z]{2,4}



            //Splitting With Regex
            //Split(string text) – splits the text by the pattern
            string text5 = "1   2 3      4";
            string pattern5 = @"\s+";

            string[] results5 = Regex.Split(text5, pattern5);
            Console.WriteLine(string.Join(", ", results5)); // 1, 2, 3, 4







            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Често използвани:



            //Вмъкване на променлива в regex.
            int m = int.Parse(Console.ReadLine());
            Regex pattern6 = new Regex(@"^([0-9]+)([a-zA-Z]{" + m + @"})([^a-zA-Z]*)$");


            //(?<=\[)(.*?)(?=\]) - прихваща всичко между два тага - в случая всичко между []


            //Matching a Username - ^[a-z0-9_-]{3,16}$                  - my-us3r_n4m3

            //We begin by telling the parser to find the beginning of the string(^),
            //followed by any lowercase letter(a - z), number(0 - 9), an underscore,
            //or a hyphen. Next, { 3,16} makes sure that are at least 3 of those
            //characters, but no more than 16.Finally, we want the end of the string($).


            //Matching a Password - ^[a-z0-9_-]{6,18}$                  - myp4ssw0rd

            //Matching a password is very similar to matching a username. The only
            //difference is that instead of 3 to 16 letters, numbers, underscores,
            //or hyphens, we want 6 to 18 of them({ 6,18}).


            //Matching a Hex Value - ^#?([a-f0-9]{6}|[a-f0-9]{3})$      - #a3c113

            //We begin by telling the parser to find the beginning of the string(^).
            //Next, a number sign is optional because it is followed a question mark.
            //The question mark tells the parser that the preceding character — 
            //in this case a number sign — is optional, but to be "greedy" and capture
            //it if it's there. Next, inside the first group (first group of parentheses),
            //we can have two different situations. The first is any lowercase letter
            //between a and f or a number six times. The vertical bar tells us that we 
            //can also have three lowercase letters between a and f or numbers instead.
            //Finally, we want the end of the string ($).


            //Matching a Slug - ^[a-z0-9-]+$                            - my-title-here

            //You will be using this regex if you ever have to work with mod_rewrite and
            //pretty URL's. We begin by telling the parser to find the beginning of the
            //string (^), followed by one or more (the plus sign) letters, numbers, or
            //hyphens. Finally, we want the end of the string ($).


            //Matching an Email - ^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$   - john@doe.com

            //We begin by telling the parser to find the beginning of the string (^). 
            //Inside the first group, we match one or more lowercase letters, numbers,
            //underscores, dots, or hyphens. I have escaped the dot because a non-escaped
            //dot means any character. Directly after that, there must be an at sign. 
            //Next is the domain name which must be: one or more lowercase letters, 
            //numbers, underscores, dots, or hyphens. Then another (escaped) dot, with
            //the extension being two to six letters or dots. I have 2 to 6 because of
            //the country specific TLD's (.ny.us or .co.uk). Finally, we want the end
            //of the string ($).


            //Matching a URL - ^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$   - http://net.tutsplus.com/about

            //This regex is almost like taking the ending part of the above regex, slapping it between
            //"http://" and some file structure at the end. It sounds a lot simpler than it really is.
            //To start off, we search for the beginning of the line with the caret.
            //The first capturing group is all option. It allows the URL to begin with 
            //"http://", "https://", or neither of them. I have a question mark after the s to allow
            //URL's that have http or https. In order to make this entire group optional,
            //I just added a question mark to the end of it.
            //Next is the domain name: one or more numbers, letters, dots, or hypens followed by another
            //dot then two to six letters or dots. The following section is the optional files and
            //directories.Inside the group, we want to match any number of forward slashes, letters,
            //numbers, underscores, spaces, dots, or hyphens. Then we say that this group can be matched
            //as many times as we want.Pretty much this allows multiple directories to be matched along
            //with a file at the end.I have used the star instead of the question mark because the star
            //says zero or more, not zero or one. If a question mark was to be used there,
            //only one file / directory would be able to be matched.
            //Then a trailing slash is matched, but it can be optional.Finally we end with the end of the line.


            //Matching an IP Address - ^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$  - 73.60.124.136

            //The first capture group really isn't a captured group because
            //was placed inside which tells the parser to not capture this 
            //group (more on this in the last regex). We also want this
            //non -captured group to be repeated three times — the {3} at
            //the end of the group. This group contains another group,
            //a subgroup, and a literal dot. The parser looks for a match
            //in the subgroup then a dot to move on.
            //The subgroup is also another non-capture group. It's just a bunch
            //of character sets (things inside brackets): the string "25"
            //followed by a number between 0 and 5; or the string "2" and
            //a number between 0 and 4 and any number; or an optional zero
            //or one followed by two numbers, with the second being optional.
            //After we match three of those, it's onto the next non-capturing group.
            //This one wants: the string "25" followed by a number between 0 and 5;
            //or the string "2" with a number between 0 and 4 and another number at
            //the end; or an optional zero or one followed by two numbers,
            //with the second being optional.
            //We end this confusing regex with the end of the string.


            //Matching an HTML Tag - ^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$

            //One of the more useful regexes on the list. It matches any HTML tag with
            //the content inside. As usually, we begin with the start of the line.
            //First comes the tag's name. It must be one or more letters long. 
            //This is the first capture group, it comes in handy when we have to grab 
            //the closing tag. The next thing are the tag's attributes. This is any 
            //character but a greater than sign(>).Since this is optional, but I want 
            //to match more than one character, the star is used.The plus sign makes 
            //up the attribute and value, and the star says as many attributes as you want.
            //Next comes the third non - capture group.Inside, it will contain either a 
            //greater than sign, some content, and a closing tag; or some spaces,
            //a forward slash, and a greater than sign.The first option looks for a greater
            //than sign followed by any number of characters, and the closing tag.
            //\1 is used which represents the content that was captured in the first 
            //capturing group.In this case it was the tag's name. Now, if that couldn't 
            //be matched we want to look for a self closing tag(like an img, br, or hr tag).
            //This needs to have one or more spaces followed by "/>".
            //The regex is ended with the end of the line.


            //String pattern validation:
            //(?s)^((?!manish).)*$      (string contains manish)
            //\d                        (at list one digit)
            //(.)*(\\d)(.)*             (contains number)
            //^\d$                      (contains only number)
            //^\d{11}$                  (contains only 11 digit number)
            //^[a-zA-Z]+$               (contains only letter)
            //^[a-zA-Z0-9]+$            (contains only letter and number)


        }
    }
}
