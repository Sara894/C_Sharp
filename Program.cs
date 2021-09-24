using System;
/* 8. Доказать (путем перебора возможных значений),
 что для любых величин А, В, С типа bool следующие 
 пары логических выражений имеют одинаковые значения (эквивалентны):   
 д) A AND (A OR В) И А */
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            bool truth = true;
            bool[] arr = new bool[2] {true,false};
            foreach(bool A in arr)
            {
                foreach(bool B in arr)
                {
                    truth &= Right(A,B) == Left(A,B);
                }
            }
    
            if(truth)
            {
                Console.WriteLine("Доказано");
            }
            Console.ReadKey();
        }

        static bool Right(bool A, bool B)
        {
            return A && (A || B);
        }

         static bool Left(bool A, bool B)
        {
            return A ;
        }
      
    }
    }
