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
            int[] arr = {7,2,3,4,1,99};
            int a= GetLengthLongestSubsequence(arr);

        
               Console.WriteLine(a);
        
            Console.ReadKey();
        }



        static int GetLengthLongestSubsequence(int[] nums)
        {
            if(nums.Length == 1)
              return 1;

            int[] lengthOfSubsequense = new int[nums.Length];

           for(int j = 1; j < nums.Length; j++)
           {
               for (int k = 0; k < j; k++)
               {
                   if (nums[j] > nums[k])
                   {
                       if(lengthOfSubsequense[j] <= lengthOfSubsequense[k])
                       {
                           lengthOfSubsequense[j] = lengthOfSubsequense[k]+1;
                       }
                   }
               }
           }

           int maximum = 0;

           foreach(int length in lengthOfSubsequense )
           {
               maximum = Math.Max(maximum,length);
           }
           return maximum;
        }
    }
}
