using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обекти_и_Класове
{
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAsleep { get; set; }

        public string SayHello()
        {
            if (IsAsleep)
            {
                return "I am sleeping, ask me later!";
            }
            return $"Hi, I am {Name}! I am {Age} years old!";
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void Awake()
        {
            IsAsleep = false;
        }
    }
}
