using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > -1 && n < 101)
            {
                if (n == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (n == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (n > 0 && n < 20)
                {
                    switch (n)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        case 10: Console.WriteLine("ten"); break;
                        case 11: Console.WriteLine("eleven"); break;
                        case 12: Console.WriteLine("twelve"); break;
                        case 13: Console.WriteLine("thirteen"); break;
                        case 14: Console.WriteLine("fourteen"); break;
                        case 15: Console.WriteLine("fifteen"); break;
                        case 16: Console.WriteLine("sixteen"); break;
                        case 17: Console.WriteLine("seventeen"); break;
                        case 18: Console.WriteLine("eighteen"); break;
                        case 19: Console.WriteLine("nineteen"); break;
                        default:
                            break;
                    }
                }
                else
                {
                    int n1 = n / 10;    //Десетица.
                    int n2 = n % 10;    //Еденица.

                    if (n1 == 2)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("twenty"); break;
                            case 1: Console.WriteLine("twenty one"); break;
                            case 2: Console.WriteLine("twenty two"); break;
                            case 3: Console.WriteLine("twenty three"); break;
                            case 4: Console.WriteLine("twenty four"); break;
                            case 5: Console.WriteLine("twenty five"); break;
                            case 6: Console.WriteLine("twenty six"); break;
                            case 7: Console.WriteLine("twenty seven"); break;
                            case 8: Console.WriteLine("twenty eight"); break;
                            case 9: Console.WriteLine("twenty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 3)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("thirty"); break;
                            case 1: Console.WriteLine("thirty one"); break;
                            case 2: Console.WriteLine("thirty two"); break;
                            case 3: Console.WriteLine("thirty three"); break;
                            case 4: Console.WriteLine("thirty four"); break;
                            case 5: Console.WriteLine("thirty five"); break;
                            case 6: Console.WriteLine("thirty six"); break;
                            case 7: Console.WriteLine("thirty seven"); break;
                            case 8: Console.WriteLine("thirty eight"); break;
                            case 9: Console.WriteLine("thirty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 4)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("fourty"); break;
                            case 1: Console.WriteLine("fourty one"); break;
                            case 2: Console.WriteLine("fourty two"); break;
                            case 3: Console.WriteLine("fourty three"); break;
                            case 4: Console.WriteLine("fourty four"); break;
                            case 5: Console.WriteLine("fourty five"); break;
                            case 6: Console.WriteLine("fourty six"); break;
                            case 7: Console.WriteLine("fourty seven"); break;
                            case 8: Console.WriteLine("fourty eight"); break;
                            case 9: Console.WriteLine("fourty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 5)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("fifty"); break;
                            case 1: Console.WriteLine("fifty one"); break;
                            case 2: Console.WriteLine("fifty two"); break;
                            case 3: Console.WriteLine("fifty three"); break;
                            case 4: Console.WriteLine("fifty four"); break;
                            case 5: Console.WriteLine("fifty five"); break;
                            case 6: Console.WriteLine("fifty six"); break;
                            case 7: Console.WriteLine("fifty seven"); break;
                            case 8: Console.WriteLine("fifty eight"); break;
                            case 9: Console.WriteLine("fifty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 6)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("sixty"); break;
                            case 1: Console.WriteLine("sixty one"); break;
                            case 2: Console.WriteLine("sixty two"); break;
                            case 3: Console.WriteLine("sixty three"); break;
                            case 4: Console.WriteLine("sixty four"); break;
                            case 5: Console.WriteLine("sixty five"); break;
                            case 6: Console.WriteLine("sixty six"); break;
                            case 7: Console.WriteLine("sixty seven"); break;
                            case 8: Console.WriteLine("sixty eight"); break;
                            case 9: Console.WriteLine("sixty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 7)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("seventy"); break;
                            case 1: Console.WriteLine("seventy one"); break;
                            case 2: Console.WriteLine("seventy two"); break;
                            case 3: Console.WriteLine("seventy three"); break;
                            case 4: Console.WriteLine("seventy four"); break;
                            case 5: Console.WriteLine("seventy five"); break;
                            case 6: Console.WriteLine("seventy six"); break;
                            case 7: Console.WriteLine("seventy seven"); break;
                            case 8: Console.WriteLine("seventy eight"); break;
                            case 9: Console.WriteLine("seventy nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 8)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("eighty"); break;
                            case 1: Console.WriteLine("eighty one"); break;
                            case 2: Console.WriteLine("eighty two"); break;
                            case 3: Console.WriteLine("eighty three"); break;
                            case 4: Console.WriteLine("eighty four"); break;
                            case 5: Console.WriteLine("eighty five"); break;
                            case 6: Console.WriteLine("eighty six"); break;
                            case 7: Console.WriteLine("eighty seven"); break;
                            case 8: Console.WriteLine("eighty eight"); break;
                            case 9: Console.WriteLine("eighty nine"); break;
                            default:
                                break;
                        }
                    }
                    if (n1 == 9)
                    {
                        switch (n2)
                        {
                            case 0: Console.WriteLine("ninety"); break;
                            case 1: Console.WriteLine("ninety one"); break;
                            case 2: Console.WriteLine("ninety two"); break;
                            case 3: Console.WriteLine("ninety three"); break;
                            case 4: Console.WriteLine("ninety four"); break;
                            case 5: Console.WriteLine("ninety five"); break;
                            case 6: Console.WriteLine("ninety six"); break;
                            case 7: Console.WriteLine("ninety seven"); break;
                            case 8: Console.WriteLine("ninety eight"); break;
                            case 9: Console.WriteLine("ninety nine"); break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
