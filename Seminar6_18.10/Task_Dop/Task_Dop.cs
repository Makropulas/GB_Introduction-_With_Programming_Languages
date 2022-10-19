// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. 
// Заполнение массива осуществить случайными числами от 50 до 100.


namespace DZ_Seminar6
{
    internal class Task_Dop
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            int[] array = GetArray(10, 50, 100);
            Console.WriteLine($"Cгенерирован массив: [{String.Join(", ", array)}]");
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Произведение элементов массива, меньших заданного числа: {ProductOfNumbers(array, number)}");
        }
        public static int[] GetArray(int size, int minValue, int maxValue)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = new Random().Next(minValue, maxValue + 1);
            }
            return result;
        }
        public static double ProductOfNumbers(int[] arr, int num)
        {
            double product = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num && product == 0) product = arr[i];
                else if (arr[i] < num) product *= arr[i];
            }
            return product;
        }
    }
}