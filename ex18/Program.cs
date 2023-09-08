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
            int[,] array =
            {
                {2, 9, 8, 12},
                {3, 1, 4, 5}, //=13
                {7, 10, 6, 11 }
              //=42
            };
            int secondLine = 1;
            int firstColumn = 0;
            int sum = array[secondLine, 0] + array[secondLine, 1] + array[secondLine, 2] + array[secondLine, 3];
            int multiplication = array[0, 0] * array[1, 0] * array[2, 0];
            Console.WriteLine($"Сумма второй строки равна: {sum}\nПроизведение первого столбца равно: {multiplication}");
        }
    }
}
