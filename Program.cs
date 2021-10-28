using System;
/* Дана строка. 
Найти в ней те слова, которые начинаются и оканчиваются одной и той же буквой.  */
namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine().ToLower();
            //Возвращает строковый массив, содержащий 
            //подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.
            string[] words = input.Split(new[] { '.', ',', ' ','!',';','-' }, StringSplitOptions.RemoveEmptyEntries);
            //Исключить элементы массива, содержащие пустые строки, из результата.
            foreach (var word in words)
                if (word[0] == word[word.Length - 1])
                    Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
