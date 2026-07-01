using System;


class program
{

    static void PrintStringNoParemetar()
    {

        Console.WriteLine("Action No Parametar");
    }

     static void PrintStringOneParametar(int N)
    {

        Console.WriteLine("Action One Parametar "+N);
    }  
    static void PrintStringTwoParametar(string Name,int N)
    {

        Console.WriteLine("Action Two Parametar "+"Name : "+Name+" Number : "+N);
    }

    static void Main()
    {
        Action NoParametar = PrintStringNoParemetar;

        Action<int> OneParemetar = PrintStringOneParametar;

        Action<string, int> TwoParametar = PrintStringTwoParametar;



        NoParametar();
        OneParemetar(44);
        TwoParametar("Mohammed", 77);
    }


}