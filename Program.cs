using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace PermutationsAndCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tPermutations and Combinations\n\t\t\t\tSE-21-1\n\t\t\t\tBy Mikhail Zhmaytsev\n");
            Console.ResetColor();

            /*Ввод элементов для перестановок*/
            Console.Write("Enter elements for permutations: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<char> charArray = new List<char>();
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if (charArray.IndexOf(ch) == -1 && ch != ' ')
                {
                    charArray.Add(ch);
                }
            }

            char[] arr = charArray.ToArray();
            Console.ResetColor();

            /*Запуск отсчета*/
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            /*Генерация перестановок и вывод*/
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Permutations.GeneratePermutations(arr);
            Console.ResetColor();

            /*Стоп отсчета и вывод времени в консоль*/
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tElapsed time: " + elapsedTime);
            Console.ResetColor();

            /*Ввод элементов для сочетаний*/
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nEnter m for combinations: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            /*Генерация сочетаний и вывод*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nResult of Combinations: {Combinations.GenerateCombinations(arr.Length, m)}");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}