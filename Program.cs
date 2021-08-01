using System;
/* Найти наименьший номер элемента последовательности,
 для которого выполняется условие М. Вывести на экран этот номер и все элементы где i = 1, 2,..., n.
*/
namespace Task4
{
    class Program
    {
      static void Main(string[] args)
      {
          Console.WriteLine("Введите число n");
          double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число e, десятичная часть через , ");
          double e = Convert.ToDouble(Console.ReadLine());
          double an ;
          double i = 1;
          while(i<n)
          {
              an = (Math.Pow(-1,i)*i)/Math.Pow(2,i);
              if (Math.Abs(an) < e)
              {
                  Console.WriteLine("Наименьший номер элемента последовательности, для которого выполняется условие М:");
                  Console.WriteLine(i);
                   Console.WriteLine(an);
                  break;
              }
              i++;
          }
          Console.WriteLine("Это все члены последовательности:");
          i = 0;
          while(i<n)
          {
              an = (Math.Pow(-1,i)*i)/Math.Pow(2,i);
              Console.WriteLine(an);
              i++;
          }
          Console.ReadKey();
      }
      
    }
}