// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine()!);
        int i = 2;

        Console.WriteLine();

        if (number < 2) Console.WriteLine("Введённое число не соответствует условиям задачи");
        else
        {
            while (i < number - 1)
            {
                Console.Write($"{i}, ");
                i = i + 2;
            }
            Console.Write($"{i}");
        }

    }
}