using static System.Console;
Clear();

/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] array = GetArray(12, -9, 9);
Write(String.Join(", ", array));
WriteLine();

int posSum = 0;
int negSum = 0;

foreach (int item in array)
{
    if (item > 0) posSum += item;
    else negSum += item;
}

WriteLine($"Сумма отрицательных эелементов {negSum}, сумма положительных элементов {posSum}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(min, max + 1);
    return result;
}
