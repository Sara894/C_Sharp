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
            int[] a = new int[8]{2,1,5,4,10,6,90,5};
            int[] b = new int[8];
            for(int i = 0; i < A.Length;i++)
            {
              for(int j = 0; j < A.Length; j++)
              {
                int[] temp = new int[2];
                if(a[i]>a[i+1])
                {
                  temp[j] = a[i+1];
                  temp[j+1] = a[i];
                }
              }
            }
            Console.ReadKey();
        }
    }
}
