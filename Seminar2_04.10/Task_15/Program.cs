/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
Обязательно сделать проверку на ввод чисел меньше 1 и больше 7

6 -> да
7 -> да
1 -> нет */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите цифру, обозначающую день недели: ");
        int numberDayOfWeek = int.Parse(Console.ReadLine()!);

        Console.WriteLine();

        if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
        {
            Console.WriteLine("Неделя состоит из семи дней!");
        }
        else
        {
            if (numberDayOfWeek == 6 || numberDayOfWeek == 7) Console.WriteLine("Этот день недели - выходной!");
            else Console.WriteLine("Этот день недели - рабочий");
        }
    }
}