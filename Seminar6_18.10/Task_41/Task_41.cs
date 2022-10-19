// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3   ----- В ЭТОМ ПРИМЕРЕ С ПОРТАЛА ОШИБКА - ОТВЕТ 4

namespace DZ_Seminar6
{
    internal class Task_41
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные и отрицательные числа через запятую или пробел");
            string nums = Console.ReadLine()!;
            Console.WriteLine($"Введённых чисел больше ноля: {AmountPositiveNumbers(nums)}");
        }
        public static int AmountPositiveNumbers(string str)
        {
            string[] newStr = str.Split(',',' ');
            int count = 0;
            for (int i = 0; i < newStr.Length; i++)
            {
                int num = Convert.ToInt32(newStr[i].ToString());
                if (num > 0) count++;
            }
            return count;
        }
    }
}

// Первое решение, через два метода и с созданием промежуточного массива... Вопрос: а надо ли? ))

// namespace DZ_Seminar6
// {
//     internal class Task_41
//     {
//         private static void Main(string[] args)
//         {
//             Console.WriteLine("Введите целые положительные и отрицательные числа через запятую или пробел");
//             string nums = Console.ReadLine()!;
//             int[] numsArray = SplitStringToArray(nums);
//             int amount = AmountPositiveNumbers(numsArray);
//             Console.WriteLine($"Введённых чисел больше ноля: {amount}");
//         }
//         public static int[] SplitStringToArray(string str)
//         {
//             string[] newStr = str.Split(',',' ');
//             int[] array = new int[newStr.Length];
//             for (int i = 0; i < newStr.Length; i++)
//             {
//                 array[i] = Convert.ToInt32(newStr[i].ToString());
//             }
//             return array;
//         }
//         public static int AmountPositiveNumbers(int[] arr)
//         {
//             int count = 0;
//             for (int i = 0; i < arr.Length; i++)
//             {
//                 if (arr[i] > 0) count++;
//             }
//             return count;
//         }
//     }
// }