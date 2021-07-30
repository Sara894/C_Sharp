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
            
            //пусть у нас треугольник со сторонами 3,4, 5
            //R = 2.5, r = 1, S = 6, a = 4, h = 3
           
           double[] t = new double[2];
             t = GetB(4,2.5,1,6);
            Console.WriteLine(t[0]);
            Console.WriteLine(t[1]);

        }

        static double[] GetB(double a, double R, double r, double S)
        {
          
              //S = a*b*c/4R;
            double bc = (S*4*R)/a;
            //S = P/2 * r
            double P = ((S/r)*2);
            double b_c = P - a;
           /*  x^2 + px + q = 0
            bc = q;
            b + c = -p; */
           double b = (b_c + Math.Pow(((b_c)*(b_c) - 4*(bc)),0.5))/2;
           double c = (b_c - Math.Pow(((b_c)*(b_c) - 4*(bc)),0.5))/2;
           double[] b_and_c = new double[2];
           b_and_c[0] = b;
           b_and_c[1] = c;
           return b_and_c;

        }
    }
}