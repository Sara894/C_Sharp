using System;
/* Дана целочисленная таблица А[n].
 Найти наименьшее число K элементов, которые можно выкинуть
  из данной последовательности,
 так чтобы осталась  возрастающая подпоследовательность
 (от меньшего к большему).
*/
namespace Task2
{
    class Program
    {
      static void Main(string[] args)
      {
          int[] arr = {555,1,2,3,777};
          Console.WriteLine("Исходный массив: ");
         
         /*  foreach (int elem in arr)
            {
               Console.Write("\t"+elem);
            }
             Console.WriteLine("_________________"); */
      
      
           for (int i = 0; i < arr.Length; i++)
         {
             try
           {
             if(arr[i]>arr[i+1] )
              {
                 Console.WriteLine(arr[i]);
              }
              else
              {
                Console.WriteLine("HHHHH "+i);
              }
           }
            catch(IndexOutOfRangeException)
        {
          Console.WriteLine("Hello, world!");
        }
         }
        
      
        
          Console.ReadKey();
         
      }

    }
        
}
