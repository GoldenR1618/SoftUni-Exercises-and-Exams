using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine().ToLower();
            string yorn = Console.ReadLine().ToLower();

            int ob6to = hrizantemi + rozi + laleta;

            if (sezon == "spring")
            {
                if (ob6to > 20)
                {
                    if (yorn == "y")
                    {
                        if (laleta > 7)
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15) * 0.95 * 0.80 + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15) * 0.80 + 2);
                        }
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 0.80 + 2);
                    }
                }
                else
                {
                    if (yorn == "y")
                    {
                        if (laleta > 7)
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15) * 0.95 + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", (hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15 + 2);
                        }
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) + 2);
                    }
                }
            }



            else if (sezon == "summer")
            {
                if (ob6to > 20)
                {
                    if (yorn == "y")
                    {
                        Console.WriteLine("{0:F2}", ((hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15) * 0.80 + 2);
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", ((hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50)) * 0.80 + 2);
                    }
                }
                else
                {
                    if (yorn == "y")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) * 1.15 + 2);
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50) + 2);
                    }
                }
            }



            else if (sezon == "autumn")
            {
                if (ob6to > 20)
                {
                    if (yorn == "y")
                    {
                        Console.WriteLine("{0:F2}", ((hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15) * 0.80 + 2);
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", ((hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15)) * 0.80 + 2);
                    }
                }
                else
                {
                    if (yorn == "y")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15 + 2);
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) + 2);
                    }
                }
            }



            else if (sezon == "winter")
            {
                if (ob6to > 20)
                {
                    if (yorn == "y")
                    {
                        if (rozi >= 10)
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15) * 0.90 * 0.80 + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15) * 0.80 + 2);
                        }
                    }
                    else if (yorn == "n")
                    {
                        if (rozi >= 10)
                        {
                            Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 0.80 * 0.90 + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 0.80 + 2);
                        }
                    }
                }
                else
                {
                    if (yorn == "y")
                    {
                        if (rozi >= 10)
                        {
                            Console.WriteLine("{0:F2}", ((hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15) * 0.90 + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) * 1.15 + 2);
                        }
                    }
                    else if (yorn == "n")
                    {
                        Console.WriteLine("{0:F2}", (hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15) + 2);
                    }
                }
            }
        }
    }
}
