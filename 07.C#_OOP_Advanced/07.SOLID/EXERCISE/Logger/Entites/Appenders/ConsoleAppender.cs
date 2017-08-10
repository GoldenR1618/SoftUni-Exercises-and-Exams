namespace Logger.Entites.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string timeStamp, string reportLevel, string message)
        {
            this.Count++;
            string formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            Console.WriteLine(formattedMsg);
        }
    }
}