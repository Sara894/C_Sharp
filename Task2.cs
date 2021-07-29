using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean numberIsReal = IsRealNumber(4,10,4);
            if (numberIsReal)
            {
                Console.WriteLine("Have Real Num!");
            }
            else{
                 Console.WriteLine("Don't have Real Num!");
            }

        }


        static Boolean IsRealNumber(double  a, double b, double c)
        {
           double b2 = Math.Pow(b,2);
           double discriminant = b2 - 4*a*c;
            Boolean numberIsReal = (discriminant >= 0) ? (true) : (false);
            return numberIsReal;

        }
    }
}