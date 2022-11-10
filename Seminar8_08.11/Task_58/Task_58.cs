// Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


namespace DZ_Seminar8
{
    internal class Task_58
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int size = 2;
            int[,] matrix1 = GetArray(size, 0, 9);
            int[,] matrix2 = GetArray(size, 0, 9);

            Console.WriteLine("Первая матрица");
            PrintArray(matrix1);
            Console.WriteLine("Вторая матрица");
            PrintArray(matrix2);

            Console.WriteLine();
            int[,] matrixResult = ProductMatrix(matrix1, matrix2, size);
            Console.WriteLine("Результирующая матрица");
            PrintArray(matrixResult);

        }

        public static int[,] GetArray(int size, int minValue, int maxValue)
        {
            int[,] result = new int[size, size];
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
        public static int[,] ProductMatrix(int[,] matr1, int[,] matr2, int size)
        {
            int[,] result = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matr1[i, k] * matr2[k, j];
                    }
                }
            }
            return result;
        }
    }
}
