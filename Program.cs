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
            int[,] m = { { 1, 2, 3 }, { 1, 3, 2 }, { 3, 2, 1 } };
            int[] arr = new int[]{1,2,3};
            int sum = 0;
            int num = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(Array.Exists(arr,element => element == m[i,j]))
                    {
                      sum +=m[i,j];
                      if(j ==2 && sum ==6)
                      {
                        Console.WriteLine("num++ " +i +" sum "+ sum);
                        num++;
                      }
                    }
                    else{
                      j = 5;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(" num: "+num);
            Console.ReadKey();
        }


    }
}
