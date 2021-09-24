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
            for ( int i =10;i<num; i++) //разбитьна функции булевкая опр палиндром или нет 
            {
                if (IsPalindrome(i*i))
                {
                    Console.WriteLine(i + " Квадрат: "+ i*i);
                }
            }
            Console.ReadKey();
        }

        static bool IsPalindrome(int num)
        {
            int temp = num ;
            int reverseNum = 0;
              while(num > 0)
            {
                int digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /=10;
            }

            if (temp == reverseNum)
               return true;
            else
               return false;
        }
    }
    }
