using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[] {33,4,45,56};
            int[] ar2 = new int[] {1,2,67,66};
            int[] newArr = Merge(ar1,ar2);
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

         static int[] Merge1(int[] arr)
        {
            
            for(int i = 0; i < arr.Length-1; i+=2)
            {
                for(int j = i; j < i+1; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;   
        }

    }
}
