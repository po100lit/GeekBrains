using static System.Console;
Clear();

/*
Задайте двумерный массив размером M × N, заполненный случайными целыми числами.
*/

GetArray(3, 4, 10, 100);

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
