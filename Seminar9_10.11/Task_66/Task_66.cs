// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


namespace DZ_Seminar9
{
    internal class Task_66
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine()!);

            if (m == n) Console.WriteLine($"Введённые числа равны - между ними нет промежутка и нечего складывать. Ответ: просто {m}");
            else Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} (включая заданные числа) = {SumElements(m, n)}");
        }
        public static int SumElements(int start, int end)
        {
            if (start > end) return SumElements(end, start);
            if (start == end) return start;
            else return start + SumElements(start + 1, end);
        }
    }
}
