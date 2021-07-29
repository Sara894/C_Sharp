using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] root = IsRealNumber(1);
           if (root[0] == 0 && root[1] == 0)
           {
               Console.WriteLine("No real root");
           }
           else{
               Console.WriteLine(root[0]);
               Console.WriteLine(root[1]);
           }

        }


        static double[] IsRealNumber(double h)
        {
            //вычисление a
            double y = (Math.Abs(Math.Sin(8 * h)) + 17) / (1 - Math.Sin(4 * h) * Math.Pow(Math.Cos(h * h + 18), 2));
            double x = Math.Abs(y);
            double a = Math.Pow(x, 0.5);
            //вычисление b
            double t = 3/( 3 + Math.Abs(Math.Tan(a*h*h)) - Math.Sin(a*h)  ) ;
            double b = 1 - Math.Pow(t, 0.5);
            double b2 = Math.Pow(b, 2);
            //вычисление c
            double c = a*h*h*Math.Sin(b*h) + b*h*Math.Cos(a*h);
            double discriminant = b2 - 4 * a * c;
            Boolean numberIsReal = (discriminant >= 0) ? (true) : (false);
            if (numberIsReal)
            {
                double[] root = new double[2];
                root = GetRealRootOfEquation(a,b,c,discriminant);
                 return root;
            }
            else
            {
                double[] root = new double[2];
                root[0] = 0;
                root[1] = 0;
                 return root;
            }
        }

        static double[] GetRealRootOfEquation(double a, double b, double c, double discriminant)
        {
            double x1 = (-b + Math.Pow(discriminant, 0.5))/2;
            double x2 = (-b -  Math.Pow(discriminant, 0.5))/2;
            double[] root = new double[2];
            root[0] = x1;
            root[1] = x2;
            return root;
        }
    }
}