using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            bool checkSbyte = (-128 <= input) && (input <= 127);
            bool checkByte = (0 <= input) && (input <= 255);
            bool checkShort = (-32768 <= input) && (input <= 32767);
            bool checkUshort = (0 <= input) && (input <= 65535);
            bool checkInt = (-2147483648 <= input) && (input <= 2147483647);
            bool checkUint = (0 <= input) && (input <= 4294967295);
            bool checkLong = (-9223372036854775808 <= input) && (input <= 9223372036854775807);

            if (checkSbyte || checkByte || checkShort || checkUshort || checkInt || checkUint || checkLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (checkSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (checkByte)
                {
                    Console.WriteLine("* byte");
                }
                if (checkShort)
                {
                    Console.WriteLine("* short");
                }
                if (checkUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (checkInt)
                {
                    Console.WriteLine("* int");
                }
                if (checkUint)
                {
                    Console.WriteLine("* uint");
                }
                if (checkLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
