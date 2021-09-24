using System;
/* Найти целые числа, которые при возведении в квадрат дают палиндромы, например 
262 
262 
 
= 676*/
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num ;
            int reverseNum = 0;
            while(num > 0)
            {
                int digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /=10;
            }
            Console.WriteLine("Перевернутое число: " + reverseNum);

            if (temp == reverseNum)
               Console.WriteLine("Это палиндром");
            else
               Console.WriteLine("Не палиндром");
            Console.ReadKey();
        }

    }
    }
