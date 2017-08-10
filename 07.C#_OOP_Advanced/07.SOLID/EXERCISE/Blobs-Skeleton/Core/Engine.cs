namespace _02.Blobs.Core
{
   using Interfaces.IO;

    public class Engine
    {
        private bool isRunning;
        private IWriter writer;
        private IReader reader;
        private GameActionsExecutor gameActionsExecutor;

        public Engine(IReader reader, IWriter writer, GameActionsExecutor gameActionsExecutor)
        {
            this.writer = writer;
            this.reader = reader;
            this.gameActionsExecutor = gameActionsExecutor;
        }

        public void Run()
        {
            this.isRunning = true;

            while (this.isRunning)
            {
                string lineRead = this.reader.ReadLine();
                if (lineRead == "drop")
                {
                    this.isRunning = false;
                    continue;
                }

                this.gameActionsExecutor.PlayAction(lineRead, this.writer);
            }
        }
    }
}
