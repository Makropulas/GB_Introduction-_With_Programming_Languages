// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


namespace DZ_Seminar8
{
    internal class Task_60
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int x = 5, y = 5, z = 5;

            Console.WriteLine($"Массив размером {x} x {y} x {z} \n");
            int[,,] array = GetArray(x, y, z);

            PrintArray(array);
        }
        public static int[,,] GetArray(int x, int y, int z)
        {
            int[,,] result = new int[x, y, z];
            int value = 10;
            for (int k = 0; k < result.GetLength(0); k++)
            {
                for (int i = 0; i < result.GetLength(1); i++)
                {
                    for (int j = 0; j < result.GetLength(2); j++)
                    {
                        if (value < 100)
                        {
                            result[i, j, k] = value;
                            value++;
                        }
                    }
                }
                if (value >= 100)
                {
                    Console.WriteLine("Неповторяющиеся двузначные числа закончились. "
                                    + "Последующие элементы массива не были заполнены \n");
                    break;
                }
            }
            return result;
        }
        public static void PrintArray(int[,,] arr)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(2); j++)
                    {
                        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
