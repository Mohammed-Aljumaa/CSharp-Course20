using System;

class Program
{

    static Predicate<int> IsEvenNumber;


    static bool IsEven(int N)
    {

        return (N % 2 == 0);
    }
    static void Main ()
    {

        IsEvenNumber = IsEven;
       Console.WriteLine( IsEvenNumber(4));


    }


}