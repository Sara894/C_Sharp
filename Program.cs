using System;

namespace Task4
{
    class Program
    {
        static void Main (string[] args)
        { 
           //double stip ;
          // double renta = 10000;
         //  int year = 10;
         int month = 0;
         while(month < 9)
         {
            Console.WriteLine( GetGrowUpPrice(10000, month));
             month++;
         }
           double costs = GetGrowUpPrice(10000, 10); 
           Console.WriteLine(costs);
           Console.ReadKey();
        }

        static double GetGrowUpPrice(double beginPrice, int countOfMonth)
        {
             double newPrice = beginPrice;
            while(countOfMonth>0)
            {
                 newPrice = 1.03 * newPrice;
                countOfMonth--;
            }
            return newPrice;
        }
    }
}