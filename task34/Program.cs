// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Урок 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] randomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i <= size - 1; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int summNumbers(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            summ += array[i];
        }
    }
    return summ;
}

int[] array = randomArray(size);

Console.WriteLine($"массив : " + string.Join(",", array));
Console.WriteLine($"сумма четных чисел массива : " + summNumbers(array));