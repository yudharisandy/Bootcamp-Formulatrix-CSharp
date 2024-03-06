// Debug and Trace
using System.Diagnostics;

class Program{
    static void Main(){
        ConsoleTraceListener consoleTraceListener = new();
        TextWriterTraceListener textWriterTraceListener = new("trace.log");
        Trace.Listeners.Add(consoleTraceListener);
        Trace.Listeners.Add(textWriterTraceListener);
        Trace.WriteLine("Start the program");
        Trace.Flush();s
    }
}