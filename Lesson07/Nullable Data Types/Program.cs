using System;

using gg = System.Console;
class NullableExamble
{


    static void Main()
    {


        Nullable<int> nullableint1 = null;


        int? nullableint2 = 56;



        if(nullableint1.HasValue)
        {
            gg.WriteLine("nullableint1 has value : " + nullableint1.Value);
        }
        else
        {

            gg.WriteLine("nullableint1 is null ");
        }
      if(nullableint2.HasValue)
        {
            gg.WriteLine("nullableint2 has value : " + nullableint2.Value);
        }
        else
        {

            gg.WriteLine("nullableint2 is null ");
        }



        //defoult

        int result = nullableint1 ?? 0;
        gg.WriteLine("Using null-coalescing operator: " + result);

        string value = nullableint2?.ToString();

        gg.WriteLine("String representation: " + (value ?? "null"));
        gg.ReadKey();
    }


}