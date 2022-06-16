using static System.Console;
Clear();

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/

Write("Введите длину стороны квадратного массива: ");
int row = int.Parse(ReadLine()!);
int col = row;

ForegroundColor = ConsoleColor.DarkYellow;
WriteLine("Сам решить не смог, нашел решение на Java и адаптировал под C#");
ForegroundColor = ConsoleColor.White;
int[,] spiral = FillSpiralArray(row, col);
PrintArray(spiral);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Write($"{array[i, j]}  "); // чтобы вывод чисел до 10 был "красивый")))
            }
            else Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] FillSpiralArray(int n, int m)
{
    int[,] array = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < array.Length; i++)
    {
        array[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        // заполнение по часовой
        col += dy;
        row += dx;
        /*
        заполнение против часовой
        col += dx;
        row += dy;
        */
    }
    return array;
}
