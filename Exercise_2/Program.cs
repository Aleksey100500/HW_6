//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21
class Program
{
    static void Main (string[] args)
    {
        int[] array = {2, 5, 10, 2};

        int mult = 0;
        for(int i = 0; i < array.Length; i++)
        {
            mult = array[i] * array[array.Length - 1 - i];

            if ( i == array.Length / 2)
            {
                break;
            }
            Console.Write($"{mult}" + " ");
        }
    }
}
