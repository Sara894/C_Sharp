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
            int[] arr = GetArray(20);


            Console.WriteLine(GetCount(arr));

            Console.ReadKey();
        }

        static int[] GetArray(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                arr[y] = rand.Next(-91, 90);
            }

            return arr;
        }

        static int GetCount(int[] arr)
        {
             int alast = arr[0];
            int count = 0;
            for(int i = 1; i< arr.Length; i++ )
            {
               if(arr[i]>alast)
                   alast = arr[i];
               else
                   count++;

            }
            return count;
        }

    
    }
    }
