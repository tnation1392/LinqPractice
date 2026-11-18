using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }

        public string Level { get; set; } = "";

        public string Message { get; set; } = "";
    }
    internal class LogAnalysis
    {
        public static void Run()
        {
            List<LogEntry> logs = new()
            {
                new LogEntry
                {
                    Timestamp = DateTime.Now.AddMinutes(-10),
                    Level = "INFO",
                    Message = "Application started"
                },
                new LogEntry
                {
                    Timestamp = DateTime.Now.AddMinutes(-5),
                    Level = "ERROR",
                    Message = "NullReferenceException occurred"
                },
                new LogEntry
                {
                    Timestamp = DateTime.Now.AddMinutes(-3),
                    Level = "WARN",
                    Message = "Low disk space"
                },
                new LogEntry
                {
                    Timestamp = DateTime.Now.AddMinutes(-1),
                    Level = "INFO",
                    Message = "User logged in"
                }
            };
            //Find error log entries
            var errorLogs =
                logs.Where(l => l.Level == "ERROR");

            //Count error log entries
            int errorCount =
                logs.Count(l => l.Level == "ERROR");
            Console.WriteLine($"\nNumber of error log entries: {errorCount}");

            foreach (var log in errorLogs)
            {
                Console.WriteLine($"Timestamp: {log.Timestamp}, Level: {log.Level}, Message: {log.Message}");
            }
        }

    }
}
