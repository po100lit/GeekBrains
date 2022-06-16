using static System.Console;
Clear();

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] array = GetRandomArray(3, 5, 10, 100);
PrintArray(array);
WriteLine();
ForegroundColor = ConsoleColor.DarkYellow;
WriteLine("в задаче написано 'по убыванию', в примере решения сортировка 'по возрастанию')))");
ForegroundColor = ConsoleColor.White;
SortArrayRow(array);


int[,] GetRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

void SortArrayRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        bool swap = true;
        while (swap)
        {
            swap = false;
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
                    swap = true;
                }

            }
        }
    }
    PrintArray(arr);
}
