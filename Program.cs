using System;

namespace C_Sharp
{
    class Program
    {
       static void Main(string[] args)
       {
           double a = 9;
           var result = GetResult( a);
           Console.WriteLine(result);
       }

       static double GetResult(double a)
       {
           double result = (5 - a);

           return result;
       }
    }
}
