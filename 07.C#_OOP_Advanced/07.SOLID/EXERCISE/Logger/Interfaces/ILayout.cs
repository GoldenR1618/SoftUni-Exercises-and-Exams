namespace Logger.Interfaces
{
    public interface ILayout
    {
        string FormatMessage(string timeStamp, string reportLevel, string message);
    }
}