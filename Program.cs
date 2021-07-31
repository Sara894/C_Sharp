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
         double costs = 0;
         while(month < 9)
         {
             costs +=  GetGrowUpPrice(10000, month);
            Console.WriteLine( GetGrowUpPrice(10000, month));
             month++;
         }
           Console.WriteLine("Это столько");
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