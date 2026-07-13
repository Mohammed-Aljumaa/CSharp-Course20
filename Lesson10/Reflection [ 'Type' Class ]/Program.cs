using System;


using Print = System.Console;


class program
{
    static void Main()
    {
        Type mytype=typeof(string);

        Print.WriteLine("Type Information : ");

        Print.WriteLine($"Name : {mytype.Name}");
        Print.WriteLine($"FullName : {mytype.FullName}");
        Print.WriteLine($"IsClass : {mytype.IsClass}");

        



    }
}