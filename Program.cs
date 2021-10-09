using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[] {400,3300,45,56};
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
            
            int[] fr = new int[4];
            for(int i = 0; i< 2 ; i++)
            {
                if(arr[i]>arr[i+2])
                {
                    fr[i] = arr[i+2];
                    fr[i+2] = arr[i];
                }
                else{
 fr[i] = arr[i];
                    fr[i+2] = arr[i+2];
                }
            } 
            return fr;   
        }

    }
}
