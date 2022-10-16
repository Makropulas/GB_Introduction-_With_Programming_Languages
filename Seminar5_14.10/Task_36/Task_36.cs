// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


namespace DZ_Seminar5
{
    internal class Task_36
    {
        private static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(4, 10)];
            FillArray(array);
            Console.WriteLine($"[{String.Join(", ", array)}]");
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {OddPositions(array)}");
        }

        public static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100);
            }
        }
        public static int OddPositions(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i = i + 2)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}