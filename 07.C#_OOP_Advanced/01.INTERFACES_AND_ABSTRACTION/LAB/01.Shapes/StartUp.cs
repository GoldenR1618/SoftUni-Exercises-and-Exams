using System;

public class StartUp
{
    public static void Main()
    {
        int radius = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        IDrawable circle = new Circle(radius);
        IDrawable rect = new Rectangle(width, height);

        circle.Draw();
        rect.Draw();
    }
}
