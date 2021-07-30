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
        {Console.WriteLine("Нажмите любую клавишу, а затем Enter");
int key1 = Console.Read();
Console.WriteLine($"Код нажатой клавиши: {key1}");
Console.WriteLine("Символьное представление: " + Convert.ToChar(key1));
            GetSideFromA(5);
            GetLittleRadiusFromA(4);
        }
        //Вычисление по одной стороне
        //сторона 
        static void GetSideFromA(double a)
        {
            Console.WriteLine("Стороны треугольника равны: " + a);
        }
          //высота 
         static void GetHeightFromA(double a)
        {
            Console.WriteLine("Высота равностороннего треугольника: " + (a*Math.Pow(3,0.5))/2);
        }
        //площадь 
        static void GetSquareFromA(double a)
        {
            Console.WriteLine("Площадь равностороннего треугольника: " + (a*a*Math.Pow(3,0.5))/4);
        } 
        //радиус вписанной 
         static void GetLittleRadiusFromA(double a)
        {
            Console.WriteLine("Радиус вписанной окружности: " + ((a*Math.Pow(3,0.5))/4));
        }
        //радиус описанной
        static void GetBigRadiusFromA(double a)
        {
            Console.WriteLine("Радиус описанной окружности: " + a);
        }

        //вычисление через высоту
        //сторона
        static double GetSideFromH(double h)
        {
            double a = (2.0*h)/Math.Pow(3,0.5);
            Console.WriteLine("Стороны треугольника равны: " + a);
            return a;
        }
        //площадь
         static void GetSquareFromH(double h)
        {
            double a =  GetSideFromH(h);
            Console.WriteLine("Площадь равностороннего треугольника:: " + (h*a)/2.0 );
        }
    }
}