using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{

    static void Procedure1(string Name, Nullable<int> Age)
    {

        Console.WriteLine("\nName is :" + Name);

        if (Age.HasValue)
        {
            Console.WriteLine("Age is :" + Age.ToString());
        }
        else
        {
            Console.WriteLine("Age is Null");
        }


    }

    static void Procedure2(string Name, int? Age)
    {

        Console.WriteLine("\nName is :" + Name);

        if (Age.HasValue)
        {
            Console.WriteLine("Age is :" + Age.ToString());
        }
        else
        {
            Console.WriteLine("Age is Null");
        }


    }


    static void Main(string[] args)
    {

        Procedure1("Mohammed Abu-Hadhoud", null);
        Procedure1("Ali Ahmed", 35);


        Procedure2("Mohammed Abu-Hadhoud", null);
        Procedure2("Ali Ahmed", 35);

        Console.ReadKey();

    }
}

