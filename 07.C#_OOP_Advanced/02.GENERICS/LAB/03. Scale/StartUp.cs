using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Scale<string> scale = new Scale<string>("R", "S");
        Console.WriteLine(scale.GetHavier());
    }
}
