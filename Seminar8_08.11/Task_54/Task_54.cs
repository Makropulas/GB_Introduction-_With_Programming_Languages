// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


namespace DZ_Seminar8
{
    internal class Task_54
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int[,] array = GetArray(3, 4, 0, 9);

            Console.WriteLine("Задан массив:\n");
            PrintArray(array);
            Console.WriteLine();

            SortingArray(array);

            Console.WriteLine("Элементы каждой строки упорядочены по убыванию:\n");
            PrintArray(array);
            Console.WriteLine();
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
        public static void SortingArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int a = 0; a < arr.GetLength(1); a++)
                {
                    for (int b = a + 1; b < arr.GetLength(1); b++)
                    {
                        if (arr[i, b] > arr[i, a])
                        {
                            temp = arr[i, a];
                            arr[i, a] = arr[i, b];
                            arr[i, b] = temp;
                        }
                    }
                }
            }
        }
    }
}
