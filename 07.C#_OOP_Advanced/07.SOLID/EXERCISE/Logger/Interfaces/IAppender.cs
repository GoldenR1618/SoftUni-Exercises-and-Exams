namespace Logger.Interfaces
{
    using Enums;

    public interface IAppender
    {
        int Count { get; }

        ILayout Layout { get; }
        
        ReportLevel ReportLevel { get; set; }

        void Append(string timeStamp, string reportLevel, string message);
    }
}