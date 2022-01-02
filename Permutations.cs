using System;
using System.Collections.Generic;
namespace PermutationsAndCombinations
{
    class Permutations
    {
        /*Метод, который рекурсивно печатает все повторяющиеся перестановки заданного массива*/
        private static void GeneratePermutationsRecursive(char[] charArray, char[] data, int last, int index)
        {
            int length = charArray.Length;

            for (int i = 0; i < length; i++)
            {
                data[index] = charArray[i];

                if (index == last)
                    Console.WriteLine(new string(data));
                else
                    GeneratePermutationsRecursive(charArray, data, last, index + 1);
            }
        }

        /*Основной метод класса*/
        public static void GeneratePermutations(char[] charArray)
        {
            int length = charArray.Length;
            char[] data = new char[length];

            Array.Sort(charArray);

            GeneratePermutationsRecursive(charArray, data, length - 1, 0);
        }

        /*Метод для перестановки элементов массива*/
        private static void Swap<T>(List<T> list, ref int indexA, ref int indexB)
        {
            (list[indexA], list[indexB]) = (list[indexB], list[indexA]);
        }
    }
}
