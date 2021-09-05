using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power: ");
             //вот почему не работал ввод с консоли
             Console.ReadKey();
        }

        static int Minimum (int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        static int LevenshteinDistance(string firstWord, string secondWord)
        {
            var n = firstWord.Length() + 1;
            var m = secondWord.Length() + 1;
            var matrixLD = new int[n, m]; 
            const int deletionCost = 1;
            const int insertionCost = 1;

            //создание матрицы для двух слов, первая строка
            for (int i = 0; i < n; i++)
            {
                matrixLD[0, i] = i;
            }
            //первый столбец матрицы
            for( int j = 0;j < m; j++)
            {
                matrixLD[j,0] = j;
            }

            for (int i = 1; i < n; i++)
            {
                for(int j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i-1] == secondWord[j-1] ? 0 : 1;
                    matrixLD[i,j] = Minimum(matrixDL[i-1,j] + deletionCost,
                                            matrixDL[i,j-1] + insertionCost,
                                            matrixDL[i-1, j-1] + substitutionCost);
                }
            }
            return matrixLD[n-1, m-1];

        }
       
    }
}
