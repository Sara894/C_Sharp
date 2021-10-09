using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[] {33,4,450,56};
            int[] newArr = Sorting(ar1);
            foreach(int val in newArr)
            {
                Console.WriteLine(val+" ");
            }
            Console.ReadKey();
        }

        static int[] Merge(int[] ar1, int[] ar2)
        {
            int[] arr = new int[(ar1.Length*2)];
                for(int j = 0; j < ar1.Length; j++)
                {
                    arr[j] = ar1[j];
                }
                int k = 0;
                for(int i = ar1.Length; i < arr.Length; i++)
                {
                    arr[i] = ar2[k];
                    k++;
                }

            return arr;   
        }

         static int[] Sorting(int[] arr)
        {
            int[] fr = new int[2];
                int[] fr1 = new int[2];
            for(int i = 0; i < (arr.Length/2 ); i++)
            {
                for(int j = 0; j < 2; j++)
                {
                     if(arr[j]>arr[j+1])
                {
                    fr[j] = arr[j+1];
                    fr[j+1] = arr[j];
                }
                }
                int t = 0;
                for(int k = 2; k< 3; k++)
                {
                      if(arr[k]>arr[k+1])
                {
                    fr1[t] = arr[k+1];
                    fr1[t+1] = arr[k];
                    t++;
                }
                }
            }
             return Merge(fr, fr1);    
        }

    }
}
