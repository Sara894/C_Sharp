using System;
/* Дана целочисленная таблица А[n]. Найти наименьшее число K элементов, 
которые можно выкинуть из данной последовательности, так чтобы осталась  возрастающая подпоследовательность.  */
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] arr = {7,2,3,4,1,99};
            int[] sub = new int[arr.Length];

            for (int i = 0; i<(arr.Length); i++)
            {
               try
               {
                     if(arr[i]>arr[i+1])
                {
                    if(arr[i]<arr[i+2])
                    sub[i+1] = arr[i+1];
                    else
                    sub[i] = arr[i];
                }
               }
               catch (IndexOutOfRangeException)
               {
                   if(arr[i-1]<arr[i])
                   {
                       sub[i] = arr[i];
                   }
               }
            }

             for (int i = 0; i<sub.Length; i++)
            {
               Console.WriteLine(sub[i]);
            }


            
            Console.ReadKey();
        }
    }
}
