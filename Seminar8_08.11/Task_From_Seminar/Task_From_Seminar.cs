// Рекомендовано решить(задача с семинара)

// Отсортировать нечетные столбцы массива по возрастанию.
// Вывести массив изначальный и массив с отсортированными нечетными столбцами


namespace DZ_Seminar8
{
    internal class Task_From_Seminar
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int[,] array = GetArray(4, 8, 0, 9);

            Console.WriteLine("Задан массив:\n");
            PrintArray(array);
            Console.WriteLine();

            int[,] newArray = SortOddColumns(array);

            Console.WriteLine("Массив с отсортированными нечётными столбцами:\n");
            PrintArray(newArray);
            Console.WriteLine();
        }

        public static int[,] GetArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] result = new int[rows, columns];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }
            return result;
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] SortOddColumns(int[,] arr)
        {
            int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
            int[] tempArray = new int[arr.GetLength(0)];

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (j % 2 != 0)
                    {
                        tempArray[i] = arr[i, j];
                    }
                    else
                    {
                        result[i, j] = arr[i, j];
                    }
                }
                if (j % 2 != 0)
                {
                    SortingArray(tempArray);
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        result[i, j] = tempArray[i];
                    }
                }
            }
            return result;
        }
        public static void SortingArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
