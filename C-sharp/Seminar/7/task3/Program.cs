using System;
using static System.Console;
Clear();

/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Допускаем что ноль - чётный.
*/

Write("Введи количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введи количество столбцов: ");
int n = int.Parse(ReadLine()!);

int[,] numbers = GetArray(m, n);
PrintArray(numbers);
WriteLine();
int[,] newArray = ChangeArray(numbers);
PrintArray(newArray);


int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(2, 10);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
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
