// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine();

        if (number1 > number2) Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");
        else Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");
    }
}