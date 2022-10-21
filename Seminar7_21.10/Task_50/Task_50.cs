// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


namespace DZ_Seminar7
{
    internal class Task_50
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int[,] array = GetArray(4, 5, 0, 9);

            Console.WriteLine("Задан массив:\n");
            PrintArray(array);
            Console.WriteLine();

            Console.Write("Введите индекс строки:  ");
            int i = int.Parse(Console.ReadLine()!);
            Console.Write("Введите индекс столбца: ");
            int j = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            PrintElementValue(array, i, j);
        }
        public static int[,] GetArray(int m, int n, int minValue, int maxValue)
        {
            int[,] result = new int[m, n];
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
       public static void PrintElementValue (int[,] arr, int i, int j)
        {
            if(i >= arr.GetLength(0) || j >= arr.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет!");
            else Console.WriteLine($"Значение запрошенного элемента: {arr[i, j]}");
        }
    }
}