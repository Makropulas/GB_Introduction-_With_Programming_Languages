// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


namespace DZ_Seminar9
{
    internal class Task_64
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"N = {num} -> {PrintNumbers(num, 1)}");
        }
        public static string PrintNumbers(int start, int end)
        {
            if (start == end) return start.ToString();
            return start + ", " + PrintNumbers(start - 1, end);
        }
    }
}
