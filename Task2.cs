using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        static Boolean IsRealNumber(double  a, double b, double c)
        {
           double b2 = Math.Pow(b,2);
           double discriminant = b2 - 4*a*c;
            Boolean numberIs = (discriminant >= 0) ? (true) : (false);
            return numberIs;

        }
    }
}