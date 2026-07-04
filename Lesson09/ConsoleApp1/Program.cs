//#define DEBUG
#define koko


using System;
using System.Diagnostics;

public class MyClass
{

    [Conditional("DEBUG")]
    public void DebugMethode()
    {

        Console.WriteLine("Debug Method execute.");
    }

    public void NormalMethode()
    {

        Console.WriteLine("Normal Method execute.");

    }





}
public class TraceExample
{
    [Conditional("koko")]
    public static void LogTrace(string message)
    {
        Console.WriteLine($"[TRACE] {message}");
    }
}
class program
{

    static void Main()
    {
        MyClass myClass = new MyClass();


        myClass.DebugMethode();
        myClass.NormalMethode();

        TraceExample.LogTrace("This trace message will only be included if koko is defined.");
        Console.WriteLine("Rest of the program.");




    }
}