using System;
using static System.Console;
Clear();

/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Write("Введите количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine()!);

int[,] numbers = GetArray(m, n);
PrintArray(numbers);
FindAverageInColumn(numbers);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void FindAverageInColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        int k = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
            k++;
        }
        double average = summ / k;
        WriteLine($"Среднее арифметическое {i + 1} столбца: {Math.Round(average, 2)}");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}  ");
        }
        WriteLine();
    }
}
