namespace Logger
{
    using Core;
    using Core.IO;
    using Entites.Appenders.Factory;
    using Entites.Layouts.Factory;
    using Interfaces;

    public class Startup
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory();

            Controller controller = new Controller(layoutFactory, appenderFactory);
            Engine engine = new Engine(reader, writer, controller);

            engine.Run();
        }
    }
}