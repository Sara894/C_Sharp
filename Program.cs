using System;
using System.Collections.Generic;
//Задание 2. Выбрать четный вариант из списка (задача на очередь) и решить его.
/* Имеется две очереди целых чисел, упорядоченных по возрастанию. 
Написать программу, которая объединяет их 
и формирует общую очередь из этих чисел, упорядоченных по возрастанию.   */
namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue<int> nums1 = new Queue<int>();
            nums1.Enqueue(3); // очередь 3
            nums1.Enqueue(5); // очередь 3, 5
            nums1.Enqueue(8); // очередь 3, 5, 8
            Queue<int> nums2 = new Queue<int>();
            nums2.Enqueue(1); // очередь 1
            nums2.Enqueue(2); // очередь 1, 2
            nums2.Enqueue(4); // очередь 1,2,4
            Queue<int> result = new Queue<int>();
            int c = nums1.Count + nums2.Count;
            int i = 0;

            while(i<c){
                
                  try{
                        if (nums1.Peek() > nums2.Peek())
                    result.Enqueue(nums2.Dequeue());
                else
                    result.Enqueue(nums1.Dequeue());
                  }

                catch (InvalidOperationException)
                {
                    if (nums1.Count == 0)
                        result.Enqueue(nums2.Dequeue());
                    else
                       result.Enqueue(nums1.Dequeue());
                }
                i++;
            }

            foreach (int j in result)
            {
                Console.WriteLine(j + " ");
            }

            Console.ReadKey();
        }
    }
}
