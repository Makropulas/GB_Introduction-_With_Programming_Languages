// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine()!);

        Console.WriteLine();

        if (number == 0) Console.WriteLine("Является ли НОЛЬ чётным числом? Наверное да! :-)");
        else if (number %2 == 0) Console.WriteLine($"Число {number} - чётное!");
        else Console.WriteLine($"Число {number} НЕ является чётным");
    }
}