namespace RecyclingStation
{
    using System;

    using RecyclingStation.Core;
    using RecyclingStation.WasteDisposal.Attributes;

    public class RecyclingStationMain
    {
        private static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();

        }
    }
}
