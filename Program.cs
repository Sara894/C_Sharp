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
            int[] arr = {2,3,4,1,99};
            int a= GetLengthLongestSubsequence(arr);
        
            Console.ReadKey();
        }



        static int GetLengthLongestSubsequence(int[] nums)
        {
            if(nums.Length == 1)
              return 1;
            
            int[] sub = new int[nums.Length];
            int k = 0;

            for(int i = 1; i < (nums.Length-1); i++)
            {
               for(int j = 0; j < i; j++)
               {
                   if(nums[j] < nums[i])
                   {
                       sub[k] = nums[i];
                       k++;
                   }
                   
               }
            }

             foreach (int val in sub)
            {
                Console.Write(val+" ");
            } 
            return 2;
        }
    }
}
