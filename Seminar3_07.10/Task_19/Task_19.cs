// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите пятизначное число: ");
        string str = Console.ReadLine()!;

        Console.WriteLine();

        if (str[0] == '-') Console.WriteLine("Отрицательные числа не принимаются :-)");
        else if (str.All(Char.IsDigit))
        {
            if (str.Length == 5)
            {
                if (str[0] == str[4] && str[1] == str[3]) Console.WriteLine("Введённое число - палиндром!");
                else Console.WriteLine("Введённое число не является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не пятизначное");
            }
        }
        else Console.WriteLine("Вводить нужно цифры и только цифры :-)");
    }
}