using System;
using static System.Console;
Clear();

/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n. Выведите полученный массив на экран.
*/

Write("Введи количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введи количество столбцов: ");
int n = int.Parse(ReadLine()!);

int[,] numbers = GetArray(m, n);
PrintArray(numbers);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
