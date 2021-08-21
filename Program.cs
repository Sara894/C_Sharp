using System;
/*     8. Алгоритм фон Неймана. Упорядочить массив  по неубыванию 
с помощью алгоритма сортировки слияниями:
1) каждая пара соседних элементов сливается
 в одну группу из двух элементов (последняя 
 группа может состоять из одного элемента);
2) каждая пара соседних двухэлементных групп 
сливается в одну четырехэлементную группу и т.д.
При каждом слиянии новая укрупненная группа упорядочивается.
*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 555, 999, 7, 3, 777 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }

    }

}
