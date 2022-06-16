using System;
using static System.Console;
using System.Linq;
Clear();

/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

Write("Введите количество строк: ");
int m = int.Parse(ReadLine()!);
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine()!);

int[,] numbers = GetArray(m, n);
PrintArray(numbers);

Write("Введите позицию элемента/искомое число: ");
int number = int.Parse(ReadLine()!);
FindNumInPosition(number, numbers);
IsMatch(number, numbers);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(100);
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
            Write($"{array[i, j]}  ");
        }
        WriteLine();
    }
}

void FindNumInPosition(int elementPosition, int[,] array)
{
    int k = array.Length;
    if (k < elementPosition)
    {
        WriteLine($"{elementPosition}-й элемент не найден. Всего в массиве {k} элементов.");
    }
    else
    {
        int[] list = array.Cast<int>().ToArray();
        // WriteLine($"{elementPosition}-й элемент массива: {list[elementPosition]}"); // поиск по индексу
        WriteLine($"{elementPosition}-й по порядку элемент массива: {list[elementPosition - 1]}"); // поиск по порядковому номеру
    }
}

void IsMatch(int number, int[,] array)
{
    bool match = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                match = true;
                break;
            }
        }
    }
    var result = (match == true) ? $"Число {number} есть в массиве." : $"Числа {number} нет в массиве.";
    WriteLine(result);
}
