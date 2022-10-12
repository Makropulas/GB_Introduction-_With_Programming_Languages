// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


namespace DZ_Seminar4
{
    internal class Task_25
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Введите степень: ");
            int degree = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            Console.WriteLine($"Число {number} в степени {degree} = {Exponentiation(number, degree)}");


        }
        public static int Exponentiation (int num, int deg)
        {
            int result = 1;
            for (int i = 1; i <= deg; i++)
            {
                result = result * num;
            }
            return result;
        }
    }
}