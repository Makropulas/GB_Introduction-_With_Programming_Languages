// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


namespace DZ_Seminar9
{
    internal class Task_68
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите неотрицательное целое m: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("Введите неотрицательное целое n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Ответ: {AkkermanFunction(m, n)}");
        }
        public static int AkkermanFunction(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
            else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        }
    }
}
