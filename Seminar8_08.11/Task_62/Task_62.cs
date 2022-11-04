// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


namespace DZ_Seminar8
{
    internal class Task_62
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            int rows = 4, columns = 4;

            int[,] array = GetArray(rows, columns);
            PrintArray(array);

            // Console.WriteLine();

            // int[,] array2 = GetArray2(rows, columns);
            // PrintArray(array2);

            Console.ReadKey();
        }

        public static void PrintArray(int[,] arr)
        {
            if (arr.GetLength(0) > 30 || arr.GetLength(1) > 30) Console.WriteLine("Матрицу со сторонами больше 30 делать не стоит");
            else
            {
                int count = 0;
                foreach (int item in arr)
                {
                    count++;
                }

                if (count < 100)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] < 10) Console.Write($"0{arr[i, j]} ");
                            else Console.Write($"{arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] < 10) Console.Write($"00{arr[i, j]} ");
                            else if (arr[i, j] >= 10 && arr[i, j] < 100) Console.Write($"0{arr[i, j]} ");
                            else Console.Write($"{arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public static int[,] GetArray(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            int i = 0, j = 0, value = 1;
            int upper = 0, bottom = rows, left = 0, right = columns;

            while (result[i, j] == 0)
            {
                while (result[i, j] == 0)
                {
                    result[i, j] = value;
                    value++;
                    if (j == right - 1)
                    {
                        i++;
                        upper++;
                        break;
                    }
                    j++;
                }
                while (result[i, j] == 0)
                {
                    result[i, j] = value;
                    value++;
                    if (i == bottom - 1)
                    {
                        j--;
                        right--;
                        break;
                    }
                    i++;
                }
                while (result[i, j] == 0)
                {
                    result[i, j] = value;
                    value++;
                    if (j == left)
                    {
                        i--;
                        bottom--;
                        break;
                    }
                    j--;
                }
                while (result[i, j] == 0)
                {
                    result[i, j] = value;
                    value++;
                    if (i == upper)
                    {
                        j++;
                        left++;
                        break;
                    }
                    i--;
                }
            }
            return result;
        }

        public static int[,] GetArray2(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            int r = 0, c = 0, value = 1;

            while (result[r, c] == 0)
            {
                for (int i = r, j = c; j < columns && result[i, j] == 0; j++, value++)
                {
                    result[i, j] = value;
                }
                r++;
                columns--;
                for (int i = r, j = columns; i < rows && result[i, j] == 0; i++, value++)
                {
                    result[i, j] = value;
                }
                rows--;
                for (int i = rows, j = columns - 1; j >= c && result[i, j] == 0; j--, value++)
                {
                    result[i, j] = value;
                }
                for (int i = rows - 1, j = c; i >= r && result[i, j] == 0; i--, value++)
                {
                    result[i, j] = value;
                }
                c++;
            }
            return result;
        }
    }
}

//---------- Сначала я написал метод GetArray2, но мне он как-то не понравился тем, что его сложно прочитать ----------
//---------- Потом я написал метод GetArray, и на самом деле, мне он тоже не нравится. Они оба отстойные ))) ----------
//------- Вроде задачу выполнил, работает с любыми размерами, но удовлетворенности результатом всё равно нет (( -------