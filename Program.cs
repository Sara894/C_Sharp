using System;

namespace C_Sharp
{
    class Program
    {
       static void Main(string[] args)
       {
         /*   Console.WriteLine("Введите число а: ");
           double a = Convert.ToDouble(Console.ReadLine()); */
           double a = 10;
           var result = GetResult(a);
           Console.WriteLine(result);
       }

       static double GetResult(double a)
       {
           double a2 = Math.Pow(a, 2);
           double x = (1 + a + a2)/(2*a + a2);
           double y = (1 - a + a2)/(2*a - a2);
           double xy = x + 2 -y;
           double fraction = Math.Pow(xy,-1);
           double result = fraction*(5 - a2);

           return result;
       }
    }
}
