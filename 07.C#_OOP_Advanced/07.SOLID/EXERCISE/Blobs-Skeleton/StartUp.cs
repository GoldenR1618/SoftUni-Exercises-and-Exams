namespace _02.Blobs
{
    using Core;
    using Core.IO;
    using Interfaces.IO;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            GameActionsExecutor gameActionsExecutor = new GameActionsExecutor();

            Engine engine = new Engine(reader, writer, gameActionsExecutor);
            engine.Run();
        }
    }
}
