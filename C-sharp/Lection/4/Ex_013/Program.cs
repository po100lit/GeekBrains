using static System.Console;
Clear();

// двумерные и многомерные массивы

string[,] table = new string[2, 5]; // [строки, столбцы]
table[1, 2] = "word";

for (int r = 0; r < 2; r++)
{
    for (int c = 0; c < 5; c++) Write($" -{table[r, c]}- ");
    WriteLine();
}
WriteLine();

// ==========================================================

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) Write($"{matr[i, j]} ");
        WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) matr[i, j] = new Random().Next(10);
    }
}
