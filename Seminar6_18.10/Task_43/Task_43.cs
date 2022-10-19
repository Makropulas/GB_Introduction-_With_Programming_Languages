// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Решение: 
// 1. приравниваем правые части данных равенств, потому что они обе равны y:
//  k1*x+b1=k2*x+b2,  выразим отсюда x: x=(b2-b1)/(k1-k2)
// Затем подставим полученное значение х в выражение для у (для любого, например первого) :
//         y=k1(b2-b1)/(k1-k2)+b1
// 2. Ответ: 
//         x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1

namespace DZ_Seminar6
{
    internal class Task_43
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 \n");
            Console.Write("Введите b1: ");
            double b1 = double.Parse(Console.ReadLine()!);
            Console.Write("Введите k1: ");
            double k1 = double.Parse(Console.ReadLine()!);
            Console.Write("Введите b2: ");
            double b2 = double.Parse(Console.ReadLine()!);
            Console.Write("Введите k2: ");
            double k2 = double.Parse(Console.ReadLine()!);
            Console.WriteLine();
            PrintResultEquation(b1, k1, b2, k2);
            Console.ReadKey();
        }
        public static void PrintResultEquation(double b1, double k1, double b2, double k2)
        {
            double x = (b2-b1)/(k1-k2);
            double y = k1*(b2-b1)/(k1-k2)+b1;
            Console.WriteLine($"Ответ: {x}; {y}");
        }
    }
}