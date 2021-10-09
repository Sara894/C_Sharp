using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[] {33,4,450,56};
            int[] ar2 = new int[] {1,2,67,66};
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
            for(int i = 0; i< 2 ; i++)
            {
                if(arr[i]>arr[i+1])
                {
                    fr[i] = arr[i+1];
                    fr[i+1] = arr[i];
                }
            } 
            int j = 0;
            for(int i = 2; i< 3 ; i++)
            {
                if(arr[i]>arr[i+1])
                {
                    fr1[j] = arr[i+1];
                    fr1[j+1] = arr[i];
                    j++;
                }
            } 
            return Merge(fr, fr1);   
        }

    }
}
