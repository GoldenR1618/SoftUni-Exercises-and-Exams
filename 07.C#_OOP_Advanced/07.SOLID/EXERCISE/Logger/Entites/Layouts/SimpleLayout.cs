namespace Logger.Entites.Layouts
{
    using Interfaces;
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}