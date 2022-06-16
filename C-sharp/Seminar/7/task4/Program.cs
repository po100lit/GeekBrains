using System;
using static System.Console;
Clear();

/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д).
*/

Write("Введи количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введи количество столбцов: ");
int n = int.Parse(ReadLine()!);

int[,] numbers = GetArray(m, n);
PrintArray(numbers);
WriteLine();
WriteLine($"Сумма элементов главной диагонали = {FindDiagSumm(numbers)}");

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

int FindDiagSumm(int[,] array)
{
    int lenght = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int summ = 0;
    for (int i = 0; i < lenght; i++)
    {
        summ += array[i, i];
    }
    return summ;
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
