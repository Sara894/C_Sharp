using System;
/* Дана целочисленная таблица А[n]. Найти наименьшее число K элементов, 
которые можно выкинуть из данной последовательности, так чтобы осталась  возрастающая подпоследовательность.  
Это все равно что найти длину наибольшей возрастающей подпоследовательности и отнять ее из длины массива
Нет, не все равно. См код ниже*/
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] arr = {7,2,3,100,500,4,1,99,9000};
            int a= GetLengthLongestSubsequence(arr);
        
            Console.ReadKey();
        }



        static int GetLengthLongestSubsequence(int[] arr)
        {
            if(arr.Length == 1)
              return 1;
            
            int[] sub = new int[arr.Length];
            int t = 0;
            int max = arr[0];
            
            for(int i = 0; i < arr.Length; i++)
            {
              
                try{
                         if(arr[i]<arr[i+1] )
                {
                    sub[t] = arr[i];
                    sub[t+1] = arr[i+1];
                    max = arr[i+1] - 1;
                    Console.WriteLine(max + "--Max");
                    t++;
                }
                else if(arr[i] > max)
                {
                    Console.WriteLine(arr[i] + "--ttttt");
                     sub[t] = arr[i];
                      t++;
                }
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Возникло исключение IndexOutOfRangeException");
                }
               
              
            }

            foreach (var item in sub)
            {
                Console.WriteLine(item + " ");
            }

            return 2;
        }
    }
}
