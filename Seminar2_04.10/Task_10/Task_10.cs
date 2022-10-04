/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Решаем с помощью "/" и "%", со строками не работаем

456 -> 5
782 -> 8
918 -> 1 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine()!);
        int result = number;

        Console.WriteLine();

        if ((number > -1000 && number < -99) || (number > 99 && number < 1000))
        {
            result /= 10;
            result %= 10;
            if (number < 0) result *= -1;
            Console.WriteLine($"Вторая цифра заданного числа: {result}");
        }
        else
        {
            Console.WriteLine("Введённое число не является трёхзначным!");
        }

    }
}