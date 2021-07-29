using System;
/* 8. Пусть элементами равностороннего треугольника являются: 
1) сторона а; 
2) площадь S; 
3) высота h; 
4) радиус вписанной окружности r; 
5) радиус описанной окружности R. 
Составить программу, которая по заданному номеру
 и значению соответствующего элемента
 вычисляла бы значение всех остальных элементов треугольника.  */
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = GetB(10,28,5,12);
            Console.WriteLine(r);

        }

        static double GetB(double a, double R, double r, double S)
        {
            //S = a*b*c/4R;
            double bc = (S*4*R)/a;
            //S = P/2 * r
            double P = ((S/r)*2);
            double b_c = P - a;
           /*  x^2 + px + q = 0
            bc = q;
            b + c = -p; */
           double b = b_c + Math.Pow(((b_c)*(b_c) - 4*(bc)),0.5);
           double c = b_c - Math.Pow(((b_c)*(b_c) - 4*(bc)),0.5);
           return c;
            

        }
    }
}