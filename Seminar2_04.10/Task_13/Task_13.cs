/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число от 1 до 100 000 : ");
        int number = int.Parse(Console.ReadLine()!);
        int result = number;

        Console.WriteLine();

        if (number < 1 || number > 100000)
        {
            Console.WriteLine("Введённое число не соответствует условиям задачи");
        }
        else if (number > 0 && number < 100)
        {
            Console.WriteLine("Во введённом числе нет третьей цифры");
        }
        else
        {
            while (result > 999)
            {
                result /= 10;
            }
            result %= 10;
            Console.WriteLine($"Третья цифра заданного числа: {result}");
        }
    }
}