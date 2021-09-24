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
            int[] arr = { 1, 5, 6, 7, 8 };

            Console.ReadKey();
        }


        static void Sort(int[] nums)
        {
            int temp;
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
            }

            // вывод
           /*  Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            } */
        }
        static int[] Merge(int[] a, int[] b)
        {
                int[] c = new int[a.Length + b.Length];
                for (int i = 0; i < a.Length; i++)
                    c[i] = a[i];
                for (int j = 0; j < b.Length; j++)
                    c[a.Length + j] = b[j];
                return c;
        }

        static int[] SortByNeiman(int[] arr)
        {
            int count = arr.Length / 2;
            int plusIndex = 2;
            int i = 0;
            while( i<arr.Length)
            {
                int[] newArr = new int[plusIndex];
                for(int j  = 0; j< plusIndex; j++)
                {
                    newArr[j] = arr[i];
                }
                Sort(newArr);
                i+=plusIndex;
            }


            return arr;
        }
    
    }
    }
