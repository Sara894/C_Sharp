using System;
/* Дана целочисленная таблица А[n].
 Найти наименьшее число K элементов, которые можно выкинуть из данной последовательности,
  так чтобы осталась  возрастающая подпоследовательность.*/
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] arr = new int[10] {5,3,3,1,18,6,7,8,9,10};
            int alast = arr[0];
            int count = 0;
            for(int i = 1; i< 10; i++ )
            {
               if(arr[i]>alast)
                   alast = arr[i];
               else
                   count++;

            }

            Console.WriteLine(count);

            Console.ReadKey();
        }

    
    }
    }
