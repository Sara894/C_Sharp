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
            int[] sub = new int[nums.Length];
            int i =0 ;

           for(int j = 1; j < nums.Length; j++)
           {
               for (int k = 0; k < j; k++)
               {
                   if (nums[j] > nums[k])
                   {
                       sub[i] = nums[j];
                       if(lengthOfSubsequense[j] <= lengthOfSubsequense[k])
                       {
                           lengthOfSubsequense[j] = lengthOfSubsequense[k]+1;
                       }
                   }
               }
               i++;
           }

           int maximum = 0;

           foreach(int length in lengthOfSubsequense )
           {
               maximum = Math.Max(maximum,length);
           }

           foreach(int num in sub)
           {
               Console.Write(num + " ");
           }
           return maximum;
        }
    }
}
/* TODO
план такой
находим наибольшую возрастающую последовательность с этим алгоритмом
потом берем его последний элемент и добавляем кнему оставшиеся в кр=онце начального массива числа
и так вытаскиваем все */