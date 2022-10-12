// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


namespace DZ_Seminar4
{
    internal class Task_29
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            int amountElements = 8;
            int[] array = new int[amountElements];
            GetArray(array);
            Console.WriteLine($"Сгенерирован массив из {amountElements} элементов: [{String.Join(", ", array)}]");
        }
        public static int[] GetArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100);
            }
            return arr;
        }
    }
}