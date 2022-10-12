// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


namespace DZ_Seminar4
{
    internal class Task_27
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите положительное целое число: ");
            string number = Console.ReadLine()!;
            if (number.Length == 1) Console.WriteLine($"Тут нечего складывать. Просто {number}");
            else if (number[0] == '-') Console.WriteLine("Нужно было ввести число больше ноля");
            else Console.WriteLine($"Сумма цифр в числе {number} -> {SumOfDigits(number)}");
        }
        public static int SumOfDigits(string num)
        {
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += Convert.ToInt32(num[i].ToString());
            }
            return result;
        }
    }
}