// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("какой длины будет массив? - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] randomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i <= size - 1; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int[] array = randomArray(size);

int negotiveSum (int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}

Console.WriteLine($"массив: " + string.Join(",", array));
Console.WriteLine($"сумма четных чисел массива : " + negotiveSum(array));