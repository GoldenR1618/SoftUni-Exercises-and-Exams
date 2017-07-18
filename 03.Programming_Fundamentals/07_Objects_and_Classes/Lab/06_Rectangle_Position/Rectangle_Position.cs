namespace _06_Rectangle_Position
{
    using System;
    using System.Linq;

    public class Rectangle_Position
    {
        public static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rectangleOne = new Rectangle
            {
                Left = arrOne[0],
                Top = arrOne[1],
                Width = arrOne[2],
                Height = arrOne[3]
            };

            int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rectangleTwo = new Rectangle
            {
                Left = arrTwo[0],
                Top = arrTwo[1],
                Width = arrTwo[2],
                Height = arrTwo[3]
            };

            if (FirstIsInsideSecond(rectangleOne, rectangleTwo))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool FirstIsInsideSecond(Rectangle fisrst, Rectangle second)
        {
            return (fisrst.Left >= second.Left) && (fisrst.Right <= second.Right) && (fisrst.Top <= second.Top) && (fisrst.Bottom >= second.Bottom);
        }
    }

    public class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }

        public int CalcArea()
        {
            return Width * Height;
        }
    }
}
