// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


namespace DZ_Seminar7
{
    internal class Task_52
    {
        private static void Main(string[] args)
        {
            int[,] array = GetArray(3, 4, 0, 9);

            Console.WriteLine("Задан массив:\n");
            PrintArray(array);
            Console.WriteLine();

            PrintAverageInColumns(array);
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
        public static void PrintAverageInColumns(int[,] arr)
        {
            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                double average = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    average += arr[i, j];
                }
                average /= arr.GetLength(0);
                if (j < arr.GetLength(1) - 1)
                {
                    Console.Write($"{Math.Truncate(average * 10) / 10}; ");
                    average = 0;
                }
                else Console.Write($"{Math.Truncate(average * 10) / 10}.");
            }
        }
    }
}
