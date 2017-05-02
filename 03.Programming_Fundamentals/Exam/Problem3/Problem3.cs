namespace Problem3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class Problem3
    {
        public static void Main(string[] args)
        {
            List<int> beehives = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hornets = Console.ReadLine().Split().Select(int.Parse).ToList();

            int power = hornets.Sum();
            int indexBee = 0;
            int indexHor = 0;
            bool beeWin = false;

            while (true)
            {                
                int currentBeehives = beehives[indexBee];

                if (currentBeehives >= power)
                {                  
                    if (indexBee == (beehives.Count - 1))
                    {
                        beehives[indexBee] = currentBeehives - power;
                        if (hornets.Count > 0)
                        {
                            hornets.RemoveAt(indexHor);
                        }
                        else
                        {
                            beeWin = true;
                            break;
                        }
                        
                        power = hornets.Sum();
                        beeWin = true;
                        break;
                    }
                    else if (indexBee < (beehives.Count - 1))
                    {
                        beehives[indexBee] = currentBeehives - power;

                        if (beehives[indexBee] == 0)
                        {
                            if (beehives.Count > 0)
                            {
                                beehives.RemoveAt(indexBee);
                            }
                            else
                            {
                                beeWin = true;
                                break;
                            }
                            
                            if (hornets.Count > 0)
                            {
                                hornets.RemoveAt(indexHor);
                            }
                            else
                            {
                                beeWin = true;
                                break;
                            }

                            power = hornets.Sum();
                        }
                        else
                        {
                            indexBee++;

                            if (hornets.Count > 0)
                            {
                                hornets.RemoveAt(indexHor);
                            }
                            else
                            {
                                beeWin = true;
                                break;
                            }

                            
                            power = hornets.Sum();

                           
                        }
                    }
                }
                else //currentBeehives < power
                {
                    if (indexBee == (beehives.Count - 1))
                    {
                        beehives.RemoveAt(indexBee);
                        beeWin = false;
                        break;
                    }
                    else
                    {
                        beehives.RemoveAt(indexBee);
                    }                   
                }
            }

            if (beeWin)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }           
        }
    }
}
