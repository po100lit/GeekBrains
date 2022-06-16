using static System.Console;
Clear();

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int[,] array1 = GetRandomArray(4, 4, 1, 10);
int[,] array2 = GetRandomArray(4, 4, 1, 10);
PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
PrintArray(ProductArrayItems(array1, array2));
WriteLine();
PrintArray(ProductMatrix(array1, array2));

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

int[,] ProductArrayItems(int[,] arr1, int[,] arr2)
{
    int[,] arr = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return arr;
}

int[,] ProductMatrix(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                res[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return res;
}