using System;
/* Дано n вещественных чисел (n=100). Упорядочить их по неубыванию методом фон Неймана: 
завести два массива A и B и записать исходные числа в А; упорядочить пары соседних чисел
 (A1 и А2, А 3 и А 4 и т.д.) и записать их В; взять из В по две соседние упорядоченные пары и,
  слив их в упорядоченные четверки, снова записать в А; 
затем каждые две соседние четверки из В слить в упорядоченные восьмерки и перенести в А и т.д */
class Program
{

    static void Main(string[] args)
        {
            Console.WriteLine("Введите размерость массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
             int pow = 1;
            if(n != Math.Pow(2,pow))
               while(n! > Math.Pow(2,pow))
               {
                   pow++;
               }
                Console.WriteLine("Степень : " + pow);
            int[] A = new int[Convert.ToInt32(Math.Pow(2,pow))] ;
            for(int i = 0; i < n ; i ++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < A.Length ; i ++)
            {
                 Console.Write(A[i]+ " ");
            }
           /*  int[] A = new int[8]{2,1,5,4,6,3,7,2};
             Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                A[i] = rnd.Next(0, 1000);
                Console.Write(A[i] + " ");
            }  */
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("                 После сортировки");
            Console.WriteLine("==================================================");
            int[] B = new int[A.Length];
            int index = 2;
            while (index != A.Length*2)
            {
                int[] temp = new int[index];
                index--;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i % index == 0 && i!=0)
                    {
                        for (int j = 0; j < temp.Length; j++)
                        {
                            temp[j] = A[i - j];
                        }
                        Array.Sort(temp);
                        Array.Reverse(temp);
                        for (int j = 0; j < temp.Length; j++)
                        {
                            B[i - j] = temp[j];
                        }
                    }
                }
                index++;
                index *= 2;
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(B[i] + " ");
            } 
            Console.ReadKey();
        }
}