using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 9, 8, 12 }, { 3, 1, 4, 5 }, { 7, 10, 6, 11 } };
            int numberOfLine = 1;
            int numberOfColumn = 0;
            int sumLineNumbers = 0;
            int multiplicationColumnNumbers = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}|");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplicationColumnNumbers *= array[i, numberOfColumn];
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumLineNumbers += array[numberOfLine, j];
            }

            Console.WriteLine($"Сумма {numberOfLine + 1} строки равна: {sumLineNumbers}\n" +
                $"Произведение {numberOfColumn + 1} столбца равно: {multiplicationColumnNumbers}");
        }
    }
}
