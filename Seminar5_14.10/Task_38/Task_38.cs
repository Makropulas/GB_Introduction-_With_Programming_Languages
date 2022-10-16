// Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


namespace DZ_Seminar5
{
    internal class Task_38
    {
        private static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(5, 10)];
            FillArray(array);
            Console.WriteLine($"[{String.Join(", ", array)}]");
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Difference(array)}");
        }

        public static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-100, 101);
            }
        }
        public static int Difference(int[] arr)
        {
            int minValue = arr[0];
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue) maxValue = arr[i];
                if (arr[i] < minValue) minValue = arr[i];
            }
            int diff = maxValue - minValue;
            return diff;
        }
        // public static int Difference(int[] arr)
        // {
        //     int minValue = arr[0];
        //     int maxValue = arr[0];
        //     for (int i = 1; i < arr.Length; i++)
        //     {
        //         if (arr[i] > maxValue) maxValue = arr[i];
        //         if (arr[i] < minValue) minValue = arr[i];
        //     }
        //     Console.WriteLine($"Минимальный элемент массива {minValue}, максимальный элемент массива {maxValue}"); //вот он этот вывод
        //     int diff = maxValue - minValue;
        //     return diff;
        // }
    }
}