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
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            arr = getDefaultArray(n);
            int SUM = getSUM(arr);
            int[,] m = getMatrix(n);
            showMatrix(m, n);

            int num = getNum(arr, m, n, SUM);
            Console.WriteLine("Количество строк: " + num);
            Console.ReadKey();
        }


        static int getNum(int[] arr, int[,] m, int n, int SUM)
        {
            int num = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array.Exists(arr, element => element == m[i, j]))
                    {
                        sum += m[i, j];
                        if (j == (n - 1) && sum == SUM)
                        {
                            num++;
                        }
                    }
                    else
                    {
                        j = n + 1;
                    }
                }
                sum = 0;
            }
            return num;
        }
        static int[] getDefaultArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        static int getSUM(int[] arr)
        {
            int SUM = 0;
            foreach (int val in arr)
            {
                SUM += val;
                Console.Write(val + " ");
            }
            Console.WriteLine(" ");
            return SUM;
        }

        static int[,] getMatrix(int n)
        {
            int[,] m = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // m[i,j] = rand.Next(1,n);
                    Console.WriteLine("Заполните матрицу: ");
                    m[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            return m;
        }

        static void showMatrix(int[,] m, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
