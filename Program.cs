using System;
/* Дана целочисленная таблица А[n]. Найти наименьшее число K элементов, 
которые можно выкинуть из данной последовательности, так чтобы осталась  возрастающая подпоследовательность.  
Это все равно что найти длину наибольшей возрастающей подпоследовательности и отнять ее из длины массива
Нет, не все равно. 
Это все равно что найти длину самой большой возрастающей подпоследовательности, полученной
зачеркиванием цифр слева направо по массиву и отнять ее длину из общей длины массива*/
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] arr = {100,7777,1,4325,32534,3,4,5,6,7,8,9,10,8,9,10,11,12,13,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            int a= GetLengthLongestSubsequence(arr);
            Console.WriteLine("Наименьшее число K элементов, которые можно выкинуть из данной последовательности, так чтобы осталась  возрастающая подпоследовательность: " + a);
        
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
                    t++;
                }
                else if(arr[i] > max)
                {
                     sub[t] = arr[i];
                      t++;
                }
                }
                catch(IndexOutOfRangeException)
                {
                }
            }

            /* foreach (var item in sub)
            {
                Console.WriteLine(item + " ");
            } */

            int lenSubsequence = 0;
            int BiggestSubLen = 0;

            for(int i = 0; i < sub.Length-1; i++)
            {
                if(arr[i]<arr[i+1])
                {
                    lenSubsequence++;
                }
                else 
                {
                    BiggestSubLen =( lenSubsequence+1 > BiggestSubLen) ? (lenSubsequence+1) : (BiggestSubLen) ;
                    lenSubsequence = 0;
                }
                BiggestSubLen =( lenSubsequence+1 > BiggestSubLen) ? (lenSubsequence+1) : (BiggestSubLen) ;
            }

            return arr.Length - BiggestSubLen;
        }
        //получилось найти длину самой большой возрастающей подпоследовательности, полученной зачеркиванием ненужных цифр
    }
}
