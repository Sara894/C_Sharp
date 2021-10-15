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
            int[] arr = new int[9]{2,1,5,4,6,3,7,2,10};
            int middle = arr.Length/2;
            int[] A = new int[middle];
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = arr[i];
            }
            for(int i = 0; i < A.Length; i++)
            {
               Console.WriteLine(A[i]);
            }
            int[] B = new int[arr.Length - middle];
            for(int i = 0; i < middle+1; i++)
            {
                B[i] = arr[i+middle];
            }
            for(int i = 0; i < B.Length; i++)
            {
               Console.WriteLine(B[i]);
            }
          //  Console.WriteLine(middle);
            Console.ReadKey();
        }
}