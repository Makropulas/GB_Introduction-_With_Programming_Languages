// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


namespace DZ_Seminar7
{
    internal class Task_47
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            
            double[,] array = GetArray(3, 4, -10, 10);

            PrintArrayFull(array);
            Console.WriteLine();

            PrintArrayRounding(array);
            Console.WriteLine();

            PrintArrayTruncate(array);
        }
        public static double[,] GetArray(int m, int n, int minValue, int maxValue)
        {
            double[,] result = new double[m, n];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
                }
            }
            return result;
        }
        public static void PrintArrayFull(double[,] arr)
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
        public static void PrintArrayRounding(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]:f1} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintArrayTruncate(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{Math.Truncate(arr[i, j] * 10) / 10} ");
                }
                Console.WriteLine();
            }
        }
    }
}

// Здесь я наглядно протестировал разницу между округлением в методе PrintArrayRounding и отсечением в методе PrintArrayTruncate.
// Оказалось, что как способ отсечения лишних символов после запятой, Math.Truncate очень хорош.