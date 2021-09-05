using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine("Расстояние Левенштейна:  " + Lev(s1,s2));
            //вот почему не работал ввод с консоли
            Console.ReadKey();
        }

        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;


        static int Lev(string word1, int len1, string word2, int len2)
        {
            if (len1 == 0)
                return len2;
            if (len2 == 0)
                return len1;

            var substitutionCost = 0;
            if (word1[len1 - 1] != word2[len2 - 1])
                substitutionCost = 1;

            var deletion = Lev(word1, len1 - 1, word2, len2) + 1;
            var insertion = Lev(word1, len1, word2, len2 - 1) + 1;
            var substitution = Lev(word1, len1 - 1, word2, len2 - 1) + substitutionCost;

            return Minimum(deletion, insertion, substitution);
        }

        static int Lev(string word1, string word2) =>
         Lev(word1, word1.Length, word2, word2.Length);


    }
}
