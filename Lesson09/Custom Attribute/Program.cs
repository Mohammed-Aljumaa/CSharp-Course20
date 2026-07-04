using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}

[MyCustom("This is a class attribute")]
class MyClass
{
    [MyCustom("This is a method attribute")]
    public void MyMethod()
    {
        Console.WriteLine("MyMethod is running...");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.MyMethod();

        Console.WriteLine("Program finished.");
    }
}
