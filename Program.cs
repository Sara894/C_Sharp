using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power: " + Power(10,2));
             //вот почему не работал ввод с консоли
             Console.ReadKey();
        }

        static long Power(long x, int n)
        {
            var result = 1L;
            while(n>0)
            {
                if((n & 1) == 0)
                {
                    x*=x;
                    n>>=1;
                }
                else
                {
                    result *=x;
                    --n;
                }
            }
            return result;
        }
    }
}
