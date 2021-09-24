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
       static  double root3 = Math.Sqrt(3);
        static void Main(string[] args)
        {

           while(true)
           {
                Console.WriteLine("Выберите дейстивие \n 1 - найти по стророне \n  2 - найти по высоте \n 3 - найти по площади \n 4 - найти по радиусу вписанной \n 5 - найти по радиусу описанной");
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
                case 1:
               {
                    Console.WriteLine("Введите сторону треугольника: ");
                  double a = Convert.ToDouble(Console.ReadLine());
                  GetAllFromSide(a);
                  break;
               }
               case 2:
               {
                    Console.WriteLine("Введите высоту треугольника: ");
                  double a = double.Parse(Console.ReadLine());
                 GetSideFromHeight(a);
                  break;
               }
                case 3:
               {
                    Console.WriteLine("Введите площадь треугольника: ");
                  double a = double.Parse(Console.ReadLine());
                 GetSideFromSquare(a);
                  break;
               }
                case 4:
               {
                    Console.WriteLine("Введите радиус вписанной треугольника: ");
                  double a = double.Parse(Console.ReadLine());
                  GetSideFromRadiusOp(a);
                  break;
               }
               case 5:
               {
                    Console.WriteLine("Введите радиус описанной треугольника: ");
                  double a = double.Parse(Console.ReadLine());
                  GetSideFromRadiusVp(a);
                  break;
               } 
               
            }
               Console.ReadKey(true);
           }
           
        }
        //Вычисление по одной стороне
        //сторона 
        static void GetAllFromSide(double a)
        {  
            Console.WriteLine("Стороны треугольника равны: " + a);
             Console.WriteLine("Высоты треугольника равны: " + a*root3/2.0);
              Console.WriteLine("Площадь треугольника равны: " + a*a*root3/4.0);
               Console.WriteLine("Радиус описанной треугольника равны: " +  a*root3/3.0);
                Console.WriteLine("Радиус вписанной треугольника равны: " +  a*root3/6.0);
        }

        static void GetSideFromHeight(double h)
        {
            double a = 2.0*h/root3;
            GetAllFromSide(a);
        }

        static void GetSideFromSquare(double S)
        {
            double a = Math.Sqrt(4.0*S/root3);
            GetAllFromSide(a);
        }

        static void GetSideFromRadiusOp(double R)
        {
            double a = 3.0*R/root3;
            GetAllFromSide(a);
        }

         static void GetSideFromRadiusVp(double r)
        {
            double a = 6.0*r/root3;
            GetAllFromSide(a);
        }
    }
    }
