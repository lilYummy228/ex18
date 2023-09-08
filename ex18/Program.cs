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
            int[,] twoDimensionalArray =
            {
                {2, 9, 8, 12},
                {3, 1, 4, 5}, //=13
                {7, 10, 6, 11 }
              //=42
            };
            int secondLine = 1;
            int firstColumn = 0;
            int sumOfSecondLine = 0;
            int multiplicationOfFirstColumn = 1;

            for (int line = 0; line < twoDimensionalArray.GetLength(0); line++)
            {
                for (int column = 0; column < twoDimensionalArray.GetLength(1); column++)
                {
                    if (column == firstColumn)
                    {
                        multiplicationOfFirstColumn *= twoDimensionalArray[line, column];
                    }

                    if (line == secondLine)
                    {
                        sumOfSecondLine += twoDimensionalArray[line, column];
                    }
                }
            }

            Console.WriteLine($"Сумма второй строки равна: {sumOfSecondLine}\nПроизведение первого столбца равно: {multiplicationOfFirstColumn}");
        }
    }
}
