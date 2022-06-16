using System;
using static System.Console;
Clear();

/*
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]
*/

Write("Введите количество элементов массива: ");
int amount = Convert.ToInt32(ReadLine());

Clear();

int[] array = new int[amount];
for (int i = 0; i < amount; i++) array[i] = new Random().Next(100);
WriteLine($"Массив из {amount} элементов: " + String.Join(", ", array));

sortedArray(array); // от себя добавил сортировку массива по возрастанию)))

void sortedArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length - 1; i++)
    {
        for (int j = i + 1; j < massiv.Length; j++)
        {
            if (massiv[j] < massiv[i])
            {
                int tmp = massiv[i];
                massiv[i] = massiv[j];
                massiv[j] = tmp;
            }
        }
    }
    WriteLine($"Сортированный массив: {String.Join(", ", massiv)}");
}
