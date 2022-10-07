// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int numberN = int.Parse(Console.ReadLine()!);
        int i = 1;

        Console.WriteLine();
        Console.Write($"Таблица кубов чисел от 1 до {numberN} ->  ");

        while (i < numberN)
        {
            double cube = Math.Pow(i, 3);
            Console.Write($"{cube}, ");
            i++;
        }
        Console.Write(Math.Pow(i, 3));
    }
}

// Решение через For (-2 строки кода)

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         Console.Write("Введите число: ");
//         int numberN = int.Parse(Console.ReadLine()!);

//         Console.WriteLine();
//         Console.Write($"Таблица кубов чисел от 1 до {numberN} ->  ");

//         for (int i = 1; i < numberN; i++)
//         {
//             double cube = Math.Pow(i, 3);
//             Console.Write($"{cube}, ");
//         }
//         Console.Write(Math.Pow(numberN, 3));
//     }
// }