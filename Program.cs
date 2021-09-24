using System;
/* Алгоритм фон Неймана. Упорядочить массив 
 a1, a2, …, an 
 a1, a2, …, an 
 
 по неубыванию с помощью алгоритма сортировки слияниями: 

1) каждая пара соседних элементов сливается в одну группу из двух элементов (последняя группа может состоять из одного элемента); 

2) каждая пара соседних двухэлементных групп сливается в одну четырехэлементную группу и т.д. 

При каждом слиянии новая укрупненная группа упорядочивается. */
namespace Task3
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] A = new int[16];
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                A[i] = rnd.Next(0, 100);
                Console.Write(A[i] + " ");
            }
             Console.WriteLine();
            Console.WriteLine("---------");

            int[] B = new int[16];
            int index = 2;
            while (index != A.Length*2)
            {
                int[] temp = new int[index];
                index--;
                for (int i = 0; i < 16; i++)
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
           Show(B);
            Console.ReadKey();
        }


        static void Show(int[] nums)
        {
           /*  int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            } */

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

    
    }
    }
