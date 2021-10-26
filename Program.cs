using System;
/* Подсчитать количество строк заданной целочисленной матрицы n×n,
 являющихся перестановкой чисел 1, 2, ..., n
 (т.е. содержащих каждое из чисел 1, 2, ..., n ровно один раз).  */
namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] a = new int[8]{100,23,3333,33,333111,4,0,1};
            int[] b = new int[8];
            b = sortJon(a);
            foreach(int val in b)
            {
              Console.Write(val+" ");
            }
            Console.ReadKey();
        }

        static int[] sortJon(int[] data)
        {
          int m = 1;
          while(m<data.Length)
          {
            int j = 0;
            while(j+m < data.Length)
            {
              sortJonMerge(j,m,m, data);
              j = j + m + m;
            }
            m = m+m;
          }
          return data;
        }

        static int[] sortJonMerge(int j, int r, int m,int[] data)
        {
          if(j + r < data.Length)
          {
            if (m == 1)
             {
               if(data[j]>data[j+r])
               {
                 int temp = data[j];
                 data[j] = data[j + r];
                 data[j+r] =  temp;
               }
             }
            else
            {
              m = m / 2;
              sortJonMerge (j,r,m,data);
              if(j+r+m < data.Length)
                sortJonMerge(j + m, r, m,data);
              sortJonMerge(j + m, r - m, m,data);
            }
          }
          return data;
        }
    }
}
