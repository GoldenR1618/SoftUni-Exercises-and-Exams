namespace _17_Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] array1 = GetArray(rows);
            int[][] array2 = GetArray(rows);
            array2 = GetReversedArray(array2);
            //PrintJaggedArray(array2);

            bool arraysFit = true;
            int cellsCount = array1[0].Length + array2[0].Length;
            for (int row = 1; row < rows; row++)
            {
                int rowLength = array1[row].Length + array2[row].Length;
                if (rowLength != array1[0].Length + array2[0].Length)
                    arraysFit = false;
                cellsCount += rowLength;
            }
            if (arraysFit)
            {
                for (int row = 0; row < rows; row++)
                    Console.WriteLine("[{0}]", string.Join(", ",
                        string.Join(", ", array1[row]),
                        string.Join(", ", array2[row])));
            }
            else
                Console.WriteLine("The total number of cells is: {0}", cellsCount);
        }

        public static int[][] GetReversedArray(int[][] array)
        {
            for (int row = 0; row < array.Length; row++)
                array[row] = array[row].Reverse().ToArray();
            return array;
        }

        public static int[][] GetArray(int rows)
        {
            int[][] array = new int[rows][];
            for (int row = 0; row < rows; row++)
                array[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            return array;
        }

        public static void PrintJaggedArray(int[][] array)
        {
            for (int row = 0; row < array.Length; row++)
                Console.WriteLine(string.Join(" ", array[row]));
        }
    }
}
