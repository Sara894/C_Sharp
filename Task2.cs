using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean numberIsReal = IsRealNumber(4, 10, 4);
            if (numberIsReal)
            {
                Console.WriteLine("Have Real Num!");
            }
            else
            {
                Console.WriteLine("Don't have Real Num!");
            }

        }


        static Boolean IsRealNumber(double h, double b, double c)
        {
            //вычисление a
            double y = (Math.Abs(Math.Sin(8 * h)) + 17) / (1 - Math.Sin(4 * h) * Math.Pow(Math.Cos(h * h + 18), 2));
            double x = Math.Abs(y);
            double a = Math.Pow(x, 0.5);
            double b2 = Math.Pow(b, 2);
            double discriminant = b2 - 4 * a * c;
            Boolean numberIsReal = (discriminant >= 0) ? (true) : (false);
            return numberIsReal;

        }
    }
}