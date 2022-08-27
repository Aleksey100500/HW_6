//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

class Program
{
    static void Main (string[] args)
    {
        int[] array = new int [123];
        int Sum = 0;


        for(int i = 0; i < array.Length; i++)
        {
            array[i]  = new Random().Next(1, 123);
        }

         for(int i = 10; i < array.Length; i++)
            {
                if(array[i] > 10 && array[i] < 99)
                {
                    Sum++;
                }
                
                if( i == 99)
                {
                    break;   
                }   
            }

        Console.Write(Sum);
    }
}