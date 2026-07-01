using System;


class program
{
    static Func<int, int> square;

    static int squareMethod(int n)
    {
        Console.WriteLine("squareMethod called");
        return n * n;
    }
     static int squareMethod3(int n)
    {
        Console.WriteLine("squareMethod3 called");
        return n * n*n;
    }

    static void Main()
    {

        square = squareMethod;
        square += squareMethod3;

        int Result =square(5);

        Console.WriteLine("Resulte is :" + Result);


    }

}