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
            int[] arr = { 555, 999, 7, 3, 777 };
           // Console.WriteLine("Исходный массив: ");

            /*  foreach (int elem in arr)
               {
                  Console.Write("\t"+elem);
               }
                Console.WriteLine("_________________"); */


            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                  if (arr[i] > arr[i + 1])
                   {
                      Console.WriteLine("Надо бы выкинуть элемент " + arr[i] + " под номером " + i);
                   }
            
                }
                catch(IndexOutOfRangeException)
                {
                  Console.WriteLine("IndexOutOfRangeException");
                }
            }


            Console.WriteLine(sum);
            Console.ReadKey();

        }

    }

}
