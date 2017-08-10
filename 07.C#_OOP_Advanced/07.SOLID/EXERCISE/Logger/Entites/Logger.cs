namespace Logger.Entites
{
    using System;
    using System.Text;
    using Enums;
    using Interfaces;

    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string timeStamp, string reportLevel, string message)
        {
            foreach (IAppender appender in this.appenders)
            {
                ReportLevel currenReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);

                if (appender.ReportLevel <= currenReportLevel)
                {
                    appender.Append(timeStamp, reportLevel.ToUpper(), message);
                }
            }
        }

        public void Error(string timeStamp, string message)
        {
            this.Log(timeStamp, "Error", message);
        }

        public void Info(string timeStamp, string message)
        {
            this.Log(timeStamp, "Info", message);
        }

        public void Fatal(string timeStamp, string message)
        {
            this.Log(timeStamp, "Fatal", message);
        }

        public void Critical(string timeStamp, string message)
        {
            this.Log(timeStamp, "Critical", message);
        }

        //Method Renamed in order to match the enumaration when called with Reflection
        public void Warning(string timeStamp, string message)
        {
            this.Log(timeStamp, "Warning", message);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Logger info");
            foreach (IAppender appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString();
        }
    }
}