using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double бюджет = double.Parse(Console.ReadLine());
            var категория = Console.ReadLine().ToLower();
            int бройХора = int.Parse(Console.ReadLine());

            double недостигащаСума = 0.00;
            double общиРазходи = 0.00;
            double останалиПари = 0.00;
            double останалБюджет = 0.00;
            double разходиТранспорт = 0.00;

            if (1 <= бройХора && бройХора <= 4)
            {
                останалБюджет = бюджет * 0.25;
                разходиТранспорт = бюджет - останалБюджет;
            }
            else if (5 <= бройХора && бройХора <= 9)
            {
                останалБюджет = бюджет * 0.40;
                разходиТранспорт = бюджет - останалБюджет;
            }
            else if (10 <= бройХора && бройХора <= 24)
            {
                останалБюджет = бюджет * 0.50;
                разходиТранспорт = бюджет - останалБюджет;
            }
            else if (25 <= бройХора && бройХора <= 49)
            {
                останалБюджет = бюджет * 0.60;
                разходиТранспорт = бюджет - останалБюджет;
            }
            else
            {
                останалБюджет = бюджет * 0.75;
                разходиТранспорт = бюджет - останалБюджет;
            }

            if (категория == "vip")
            {
                общиРазходи =  бройХора * 499.99 + разходиТранспорт;
                останалиПари = бюджет - общиРазходи;
                недостигащаСума = общиРазходи - бюджет;
            }
            else if (категория == "normal")
            {
                общиРазходи = бройХора * 249.99 + разходиТранспорт;
                останалиПари = бюджет - общиРазходи;
                недостигащаСума = общиРазходи - бюджет;
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (бюджет >= общиРазходи)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", останалиПари);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", недостигащаСума);
            }
        }
    }
}
