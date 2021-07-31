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
          double n = 2;
          double t = 29;
          double e = Math.Abs(t);
          double an ;
          double i = 1;
          while(i<n)
          {
              an = (Math.Pow(-1,i)*i)/Math.Pow(2,i);
              if (an < e)
              {
                  Console.WriteLine(i);
                  break;
              }
              i++;
          }
          Console.ReadKey();
      }
      
    }
}