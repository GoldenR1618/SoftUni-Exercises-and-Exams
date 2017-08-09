namespace _02.Graphic_Editor
{
    public class StartUp
    {
        public static void Main()
        {
            IShape circle = new Circle();
            IShape square = new Square();
            IShape rectangle = new Rectangle();

            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(circle);
            editor.DrawShape(square);
            editor.DrawShape(rectangle);
        }
    }
}
