using System;

class Program
{
    Func<int, int> square = n => n * n;

    Func<int> getRandom = () => new Random().Next(1, 10);

    Func<int, int, int> add = (a, b) => a + b;

    Predicate<int> IsEven = n => n % 2 == 0;

    Action<string> print = msg => Console.WriteLine(msg);

    static void Main()
    {
        Program p = new Program();

        // مثال 1: مربع العدد
        int sq = p.square(5);
        Console.WriteLine("Square: " + sq);

        // مثال 2: رقم عشوائي
        int rnd = p.getRandom();
        Console.WriteLine("Random: " + rnd);

        // مثال 3: جمع رقمين
        int sum = p.add(3, 7);
        Console.WriteLine("Sum: " + sum);

        // مثال 4: هل الرقم زوجي؟
        bool even = p.IsEven(4);
        Console.WriteLine("IsEven: " + even);

        // مثال 5: طباعة رسالة
        p.print("Hello MJ!");
    }
}
