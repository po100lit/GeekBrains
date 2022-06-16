using static System.Console;
Clear();

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

int[,,] result = GetThreeDimensionArray(2, 2, 2); // создаем массив
PrintArray(result); // печатаем массив

// генератор трехмерного массива
int[,,] GetThreeDimensionArray(int m, int n, int o)
{
    int[,,] arr = new int[m, n, o];
    int[] listNumbers = RandomNonRepeatNumbers(m * n * o);
    int r = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = listNumbers[r];
                r++;
            }
        }
    }
    return arr;
}

// генератор списка неповторяющихся чисел
int[] RandomNonRepeatNumbers(int lenght)
{
    var rand = new Random();
    var knownNumbers = new HashSet<int>();
    var arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        int newElement;
        do
        {
            newElement = rand.Next(10, 100);
        }
        while (!knownNumbers.Add(newElement));
        arr[i] = newElement;
    }
    return arr;
}

// печать массива
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Write($"{arr[i, j, k]} ({i},{j},{k}) ");
            }
            WriteLine();
        }
        //WriteLine();
    }
}
