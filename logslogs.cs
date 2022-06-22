using System;

namespace nloslogs
{
    class LogLine
    {

        static public LogLevel ParseLogLevel(string log)
        {

            string newLog = log.Substring(1, 3);

            switch (newLog)
            {
                case "TRC":
                    log = "Trace";
                    break;
                case "DBG":
                    log = "Debug";
                    break;
                case "INF":
                    log = "Info";
                    break;
                case "WRN":
                    log = "Warning";
                    break;
                case "ERR":
                    log = "Error";
                    break;
                case "FTL":
                    log = "Fatal";
                    break;
                default:
                    log = "Desconhecido";
                    break;

            }

            LogLevel check;
            bool checkParse = Enum.TryParse(log, out check);

            return check;


        }
        public enum LogLevel
        {
            Trace,
            Debug,
            Info,
            Warning,
            Error,
            Fatal,
            Desconhecido
        }

    }
}