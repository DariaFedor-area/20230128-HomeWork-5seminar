// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */


Console.Write("определите какой длины массив: ");
int size = Convert.ToInt32(Console.ReadLine());

float[] newArray(int size, int start, int end) //создаем рандомный массив
{
    float[] array = new float[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
float[] array = newArray(size, 0, 100);
Console.WriteLine($"массив: " + string.Join("; ", array));


float[] sorting(int size)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        float temp = array[i];
        array [i] = array [minPosition];
        array [minPosition] = temp;

    }
    return array;
}
float[] array1 = sorting(size);
//Console.WriteLine($"сортировка: " + string.Join("; ", array1));

float difference = array1[size-1] - array1[0];
Console.WriteLine($"разница между максимальным и минимальным элементом массива: {difference}");



