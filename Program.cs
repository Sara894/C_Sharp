using System;
/* Найти целые числа, которые при возведении в квадрат дают палиндромы, например 26^2= 676.
*/
namespace Task2
{
    class Program
    {
      static void Main(string[] args)
      {
         Console.WriteLine(307*307);
          int n =100000;
          int i = 10;
          while (i<n)
          {
            
              bool s = IsPalindrome(i*i, i);
              if (s)
              {
                  Console.WriteLine("Палиндром дает -- "+i);
              }
              i++;
          }
          Console.ReadKey();
         
      }

      static bool IsPalindrome(int square, int i)
      {
        /* square = 121;
        i = 11;
        121 = 100*1 + 2*10 + 1;
        if (1 == 1)
          return true; */
          //Console.WriteLine("Square  " + (square ) + "  i = "+i+"\n");
          int square_div_100 = square / 100;
            int hundred_mod = square / 100;
          int ten_mod = square % 10;
        if (square_div_100< 10)
        {
            
          if (hundred_mod == ten_mod)
          {
              return true;
          }
        
        return false;
      }
      else if (square_div_100 > 10)
      {
         return IsPalindromeForBigNumber( square);
      }
      else
      {
          return false;
      }
      
    }

    static bool IsPalindromeForBigNumber(int square)
    {
      
      string squareStr = square.ToString();
      char[] straight = squareStr.ToCharArray();
      char[] reverse = squareStr.ToCharArray();
       Array.Reverse(reverse);
        int s =0;
       for (int i = 0; i < reverse.Length; ++i)
       {
        
         if( straight[i] == reverse[i])
           s++;
        
       }
       if (s == reverse.Length)
         return true;
      else
        return false;
       }
     
     
    }
}
