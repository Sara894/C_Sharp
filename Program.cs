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
        
            Console.ReadKey();
        }



        static int GetLengthLongestSubsequence(int[] nums)
        {
            if(nums.Length == 1)
              return 1;
            
            int[] sub = new int[nums.Length];
            int max = 0;
            int maxIndex = 0;

            for(int i = 0; i < (nums.Length-1); i++)
            {
               try
               {
                     if(nums[i] < nums[i+1] )
                {
                    sub[i] = nums[i];
                    sub[i+1]=nums[i+1];
                    max = nums[i+1];
                    maxIndex = i+1;

                }
                else
                {
                    for  (int y = maxIndex; y<nums.Length; y++)
                    {
                        if(max<nums[y])
                        {
                            max = nums[y];
                            sub[i] = nums[y];
                        }
                    }
                }
               }
               catch (IndexOutOfRangeException)
               {
                   
                   Console.WriteLine("JJJJ");
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
