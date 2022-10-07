// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Введите координаты первой точки");
        Console.Write($"X: ");
        double xA = double.Parse(Console.ReadLine()!);
        Console.Write("Y: ");
        double yA = double.Parse(Console.ReadLine()!);
        Console.Write("Z: ");
        double zA = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Введите координаты второй точки");
        Console.Write("X: ");
        double xB = double.Parse(Console.ReadLine()!);
        Console.Write("Y: ");
        double yB = double.Parse(Console.ReadLine()!);
        Console.Write("Z: ");
        double zB = double.Parse(Console.ReadLine()!);

        Console.WriteLine("-----------------------------------");

        double distance = Math.Sqrt((Math.Pow((xB - xA), 2))
                                  + (Math.Pow((yB - yA), 2))
                                  + (Math.Pow((zB - zA), 2)));

        Console.WriteLine($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) -> {Math.Truncate(distance * 100) / 100}");
    }
}

// Решение через строку


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         Console.Write("Введите через запятую и без пробелов три координаты точки A: ");
//         string strA = Console.ReadLine()!;
//         string[] a = strA.Split(',');

//         Console.Write("Введите через запятую и без пробелов три координаты точки B: ");
//         string strB = Console.ReadLine()!;
//         string[] b = strB.Split(',');

//         Console.WriteLine("-------------------------------------------------------------------");

//         if (a.Length == 3 && b.Length == 3)
//         {
//             double distance = Math.Sqrt((Math.Pow(double.Parse(b[0]) - double.Parse(a[0]), 2))
//                                       + (Math.Pow(double.Parse(b[1]) - double.Parse(a[1]), 2))
//                                       + (Math.Pow(double.Parse(b[2]) - double.Parse(a[2]), 2)));

//             Console.WriteLine($"A ({a[0]}, {a[1]}, {a[2]}); B ({b[0]}, {b[1]}, {b[2]}) -> {Math.Truncate(distance * 100) / 100}");
//         }
//         else Console.WriteLine("Нужно было ввести три координаты через запятую и без пробелов - 'X,Y,Z'");
//     }
// }