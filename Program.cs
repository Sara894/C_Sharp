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
            GetSideFromA(5);
            GetLittleRadiusFromA(4);
        }

        static void GetSideFromA(double a)
        {
            Console.WriteLine("Стороны треугольника равны: " + a);
        }
         static void GetLittleRadiusFromA(double a)
        {
            Console.WriteLine("Радиус вписанной окружности: " + ((a*Math.Pow(3,0.5))/4));
        }
        
        static void GetBigRadiusFromA(double a)
        {
            Console.WriteLine("Радиус описанной окружности: " + a);
        }
        
        static void GetSquareFromA(double a)
        {
            Console.WriteLine("Площадь равностороннего треугольника: " + (a*a*Math.Pow(3,0.5))/4);
        } 

         static void GetHeightFromA(double a)
        {
            Console.WriteLine("Высота равностороннего треугольника: " + (a*Math.Pow(3,0.5))/2);
        } 
    }
}