using System;
/* Доказать (путем перебора возможных значений), что для любых величин
 А, В, С типа bool следующие пары логических выражений имеют одинаковые значения (эквивалентны): 
 а) A OR B и B OR А; 
б) A AND В И В AND A; 
в) (A OR В) OR С И A OR С; 
г) (A AND В) AND С И A AND (В AND С) ; 
д) A AND (A OR В) И А; 
е) A OR (A AND В) И А; 
ж) A AND (В OR С) И (A AND В) OR (A AND С); 
з) A OR (В AND С) И (A OR В) AND (A OR С).
*/
namespace Task4
{
    class Program
    {
        static bool Right(bool A, bool B)
        {
            return A || B;
        }

        static bool Left(bool A, bool B)
        {
            return B || A;
        }

        static void Main(string[] args)
        {
            bool A = true;
            bool B = true;
            bool truth = true;
            //true;
            truth &= Left(A,B) == Right(A,B);//логические умножения
            A = true;
            B = false;
            truth &= Left(A,B) == Right(A,B);
            A = false;
            B = true;
            truth &= Left(A,B) == Right(A,B);
             A = false;
            B = false;
            truth &= Left(A,B) == Right(A,B);
            Console.WriteLine(truth ? "Доказано" : "Не доказано");
            Console.ReadKey();

        }

      
    }
}