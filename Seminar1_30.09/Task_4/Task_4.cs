// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ВВЕДИТЕ ТРИ ЦЕЛЫХ ЧИСЛА И УЗНАЙТЕ, КАКОЕ ИЗ НИХ ЯВЛЯЕТСЯ МАКСИМАЛЬНЫМ \n");

        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите третье число: ");
        int number3 = int.Parse(Console.ReadLine()!);

        int max = number1;

        Console.WriteLine();

        if (number2 > number1) max = number2;
        if (number3 > number2) max = number3;
        Console.WriteLine($"Максимальное из трёх чисел: {max}");
    }
}