using System;
using System.Diagnostics;


class Program
{
    static void Main()
    {
        // Specify the source name for the event log
        string sourceName = "MyApp";


        // Create the event source if it does not exist
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, "Application");
            Console.WriteLine("Event source created.");
        }


        // Log an information event
        EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);


        Console.WriteLine("Event written to the log.");
    }
}
