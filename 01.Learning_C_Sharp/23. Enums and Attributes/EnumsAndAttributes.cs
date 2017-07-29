namespace Enums_and_Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnumsAndAttributes
    {
        public static void Main(string[] args)
        {
            //Enumerations:
            //Object type, limited to a set of values:
            Season season1 = Season.Summer;

            //You can use enum values in a switch-case statements:
            switch (season1)
            {
                case Season.Spring:
                    //… 
                    break;

                case Season.Summer:
                    //… 
                    break;

                case Season.Autumn:
                    //… 
                    break;

                case Season.Winter:
                    //… 
                    break;
            }

            //Underlying value of this enum is int:
            if (season1 == Season.Spring)
            {
                Console.WriteLine((int)season1); //0
            }

            //GetValues() – returns an array with all constants:
            Array seasons = Enum.GetValues(typeof(Season)); //Връща целите обекти в масива.
            string[] names = Enum.GetNames(typeof(Season)); //Връща масив от имената.

            //Enum Parse:
            //A string value can be convert to an equivalent enum:
            Season s1 = (Season)Enum.Parse(typeof(Season), "Summer");    //Summer. Трябва да го кастнем към Enum.
            //A int value have to be parsed to string first and then to enum:
            int number = 1;
            Season s2 = (Season)Enum.Parse(typeof(Season), number.ToString());  //Summer
            //Safety convert to enum:
            Season season2;
            if (Enum.TryParse("1", out season2))
            {
                Console.WriteLine(season2);   // Summer
            }
            if (Enum.TryParse("9", out season2))
            {
                Console.WriteLine(season2);   // 9 - ако няма Enum с такъв int, не гърми а връща цифрата.
            }
            if (Enum.TryParse("Dog", out season2))
            {
                Console.WriteLine(season2);   // Ако подадем string, който не съответства на името на никой Enum, нищо не се случва.
            }

            //Comparing Enums:
            Season season3 = Season.Summer;
            Season season4 = Season.Winter;
            Console.WriteLine(season3.CompareTo(season4));   //Comparison of ordinal values -> -1



            //Attributes:
            //  Data holding class.
            //  Describes parts of your code.
            //  Applied to: Classes, Fields, Methods, etc.
            //Attributes Usage:
            //  Generate compiler messages or errors.
            //  Tools:
            //      Code generation tools.
            //      Documentation generation tools.
            //      Testing Frameworks
            //  Runtime – ORM, Serialization etc.

            //Example:
            //[Flags] attribute indicates that the enum type can be treated like a set of bit flags stored as a single integer.
            //[Obsolete] - предупреждение за остарял код още по време на компилацията.

            //Attributes with Parameters:
            //Attributes can accept parameters for their constructors and public properties.
            //  [DllImport("user32.dll", EntryPoint="MessageBox")]

            //Set a Target to an Attribute:
            //  [assembly: AssemblyTitle("Attributes Demo")]
            //  [assembly: AssemblyCompany("DemoSoft")]
            //  [assembly: AssemblyProduct("Enterprise Demo Suite")]
            //  [assembly: AssemblyVersion("2.0.1.37")]

            //Custom Attributes:
            //  Must inherit the System.Attribute class
            //  Their names must end with "Attribute"
            //  Possible targets must be defined via[AttributeUsage]
            //  Can define constructors with parameters
            //  Can define public fields and properties
        }
    }

    //Enum:
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    //Enum Custom Value:
    public enum CoffeePrice
    {
        None,
        Small = 50,
        Normal = 100,
        Double = 200
    }
}
