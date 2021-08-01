using System;
/* Найти целые числа, которые при возведении в квадрат дают палиндромы, например 26^2= 676.
*/
namespace Task1
{
    class Program
    {
      static void Main(string[] args)
      {
          int n = int.Parse(Console.ReadLine());
          int i = 10;
          while (i<n)
          {
            
              bool s = IsPalindrome(i*i);
              if (s)
              {
                  Console.WriteLine("Палиндром дает -- "+i);
              }
              i++;
          }
          Console.ReadKey();
      }

      static bool IsPalindrome(int square)
      {
         string str = square.ToString();
         if (str[0] == str[2])
         {
             return true;
         }
         return false;
      }
      
    }
}