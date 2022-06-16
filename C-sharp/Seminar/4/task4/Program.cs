using System;
using static System.Console;
Clear();

/*
Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Write("Введите количество эдементов массива: ");
int num = Convert.ToInt32(ReadLine());
int[] array = new int[num];
fillArray(array);
int count0 = Count(array);
int count1 = array.Length - count0;
PrintArray(array);

WriteLine(String.Join(",", array));
WriteLine($"{count0} - количество нулей; {count1} - количество единиц");

int Count(int[] array)
{
    int count0 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0) count0 += 1;
    }
    return count0;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Write($"{array[i]} ");
}

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(2);
}
