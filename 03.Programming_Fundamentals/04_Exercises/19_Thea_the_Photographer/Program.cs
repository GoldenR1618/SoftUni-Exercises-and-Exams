using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong totalPictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong percentageGoodPictures = ulong.Parse(Console.ReadLine());
            ulong uploadTime = ulong.Parse(Console.ReadLine());



            ulong filteredPictures = (ulong)Math.Ceiling(totalPictures * (percentageGoodPictures * 0.01));
            ulong totalTime =  totalPictures * filterTime + filteredPictures * uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            string timeToPrint = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeToPrint);
        }
    }
}
