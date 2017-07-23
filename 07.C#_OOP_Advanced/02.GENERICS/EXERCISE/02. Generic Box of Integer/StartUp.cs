using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(box.ToString());
        }
    }
}
