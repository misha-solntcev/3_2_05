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

        // Основная функция поиска слов текста, в которых есть хотя бы одна цифра.
        static string FindDigit(char[][] myChar)
        {
            string newString = "";
            for (int i = 0; i < myChar.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < myChar[i].Length; j++)
                {
                    if (Char.IsDigit(myChar[i][j]) == true)
                    {
                        flag = true;
                        break;
                    }
                }
                // Переводим обратно массив букв (char[]) в слова (string).
                string newWord = "";                
                {
                    foreach (char ch in myChar[i])
                        newWord += ch;
                }

                if (flag == true)
                    newString += newWord + " ";
            }
            return newString;
        }

        // Главная функция Main.
        static void Main(string[] args)
        {
            string myString = "abcd1 defg fh2aslk fdgjl.";
            
            string newString = FindDigit(WordsToChars(StringToWords(myString)));
            Console.WriteLine(newString);

            Console.ReadKey();
        }
    }
}