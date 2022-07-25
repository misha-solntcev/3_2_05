using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 5
Дана строка.Словом текста считается любая последовательность цифр и букв
латинского алфавита; между соседними словами - не менее одного пробела, за
последним словом - точка. Найти и сохранить в строке те слова текста, в которых есть
хотя бы одна цифра. Все остальные слова удалить.*/

namespace _3_2_05
{
    internal class Program
    {        
        // Функция преобразования строки в массив слов.
        static string[] StringToWords(string myString)            
        {
            char[] sep = { ' ', '.' };
            string[] myWords = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            return myWords;
        }
        // Функция преобразования массив слов в ступенчатый массив букв.
        static char[][] WordsToChars(string[] myWords)
        {
            char[][] myChar = new char[myWords.Length][];
            for (int i = 0; i < myWords.Length; i++)
                myChar[i] = myWords[i].ToCharArray();
            return myChar;
        }

        static void Main(string[] args)
        {
            string myString = "abcd1 defg fh2aslk fdgjl.";
            char[][] myChar = WordsToChars(StringToWords(myString));
            foreach (char[] word in myChar)
            {
                foreach (char ch in word)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
                
                
                    

            Console.ReadKey();

                
        }
    }
}