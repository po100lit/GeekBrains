using System;
using static System.Console;
Clear();

/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Write("Введите количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine()!);

double[,] numbers = GetArray(m, n);
PrintArray(numbers);

double[,] GetArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = GetRealNumber();
        }
    }
    return result;
}

double GetRealNumber()
{
    int[] signNumber = new int[] { -1, 1 };
    int rnd = new Random().Next(2);
    double num = Math.Round(new Random().NextDouble() * 10 * signNumber[rnd], 1);
    return num;
}

void PrintArray(double[,] array)
{
    WriteLine();
    WriteLine($"Массив случайных вещественных чисел из {m} строк и {n} столбцов:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}  ");
        }
        WriteLine();
    }
}
