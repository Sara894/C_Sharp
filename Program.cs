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

        static int Power(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if((n & 1) == 0)
            {
                int power = Power(x, n >> 1);
                return power * power;
            }
            else
            {
                return x*Power(x, n-1);
            }
        }
    }
}
