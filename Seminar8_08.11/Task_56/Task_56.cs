// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


namespace DZ_Seminar8
{
    internal class Task_56
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int[,] array = GetArray(5, 4, 0, 9);

            Console.WriteLine("Задан массив:\n");
            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine($"Строка с наименьшей суммой элементов: {FindRowWithMinSum(array)}");
        }

        public static int[,] GetArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] result = new int[rows, columns];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }
            return result;
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static int FindRowWithMinSum(int[,] arr)
        {
            int[] sumsInRows = new int[arr.GetLength(0)];
            int minRow = 1, minSum = 0, count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sumsInRows[i] += arr[i, j];
                }
            }
            for (int i = 0; i < sumsInRows.Length; i++)
            {
                if (i == 0) minSum = sumsInRows[i];
                else if (sumsInRows[i] < minSum)
                {
                    minSum = sumsInRows[i];
                    minRow = i + 1;
                }
                // Console.WriteLine($"Сумма элементов в строке {i + 1}: {sumsInRows[i]}.  minSum: {minSum}. minRow: {minRow}"); //Проверка
            }
            for (int i = 0; i < sumsInRows.Length; i++)
            {
                if (sumsInRows[i] == minSum) count++;
            }
            if (count > 1) Console.WriteLine($"Количество строк с одинаковой наименьшей суммой элементов: {count}. Будет указана первая из них");
            return minRow;
        }
        // public static int FindRowWithMinSum(int[,] arr)
        // {
        //     int minRow = 1, minSum = 0;
        //     for (int i = 0; i < arr.GetLength(0); i++)
        //     {
        //         int sumElementsInRow = 0;
        //         for (int j = 0; j < arr.GetLength(1); j++)
        //         {
        //             sumElementsInRow += arr[i, j];             //Этот метод лаконичный, но не отображает, если есть несколько минимальных строк
        //         }
        //         if (i == 0) minSum = sumElementsInRow;
        //         else if (sumElementsInRow < minSum)
        //         {
        //             minSum = sumElementsInRow;
        //             minRow = i + 1;
        //         }
        //     }
        //     return minRow;
        // }
    }
}
