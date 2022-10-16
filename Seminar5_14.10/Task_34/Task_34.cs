// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


namespace DZ_Seminar5
{
    internal class Task_34
    {
        private static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(4, 10)];
            FillArray(array);
            Console.WriteLine($"[{String.Join(", ", array)}]");

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество чётных чисел в массиве: {count}");
        }

        public static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100, 1000);
            }
        }
    }
}