using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {4,3,2,1};
            int[] newArr = Merge(arr,4);
            foreach(int val in newArr)
            {
                Console.WriteLine(val+" ");
            }
            Console.ReadKey();
        }

        static int[] Merge(int[] arr,int t)
        {
                for(int i = 0; i < arr.Length-1; i+=4)
            {
                for(int j = i; j < i+3; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                       // Console.WriteLine("arr[i]" + arr[i])
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
