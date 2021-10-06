﻿using System;
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



        static int GetLengthLongestSubsequence(int[] nums)
        {
            if(nums.Length == 1)
              return 1;
            
            int[] sub = new int[nums.Length];
             int max = nums[0];
            int maxIndex = 0; 
            int i = 0;

            while(i < (nums.Length))
            {
                try
                {
                     if(nums[i]<nums[i+1] && ((i == maxIndex + 1 ) || nums[i]>=max))
                {
                    sub[i] = nums[i];
                    max = nums[i+1];
                    maxIndex = i+1;
                }
                else
                {
                    if(nums[i]>=max && nums[i]>nums[i+1] && i != 0)
                       {
                           max = nums[i];
                           sub[i] = max;
                           maxIndex = i;
                         //  nums[i+1] = max;
                       }

                }
                }
                catch (IndexOutOfRangeException)
                {
                    
                    if(nums[i-1]<nums[i] && ( nums[i]> max))
                    {
                        sub[i] = nums[i];
                    }
                }
                 i++;
            }

            foreach (int val in sub)
            {
                Console.Write(val+" ");
            }
            return 2;
        }
    }
}
