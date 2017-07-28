using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {     
        int[] stones = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Lake<int> lake = new Lake<int>(stones);

        Console.WriteLine(string.Join(", ", lake));
    }
}