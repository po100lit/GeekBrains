using System;
using static System.Console;

Clear();

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int i = 1;
while (i <= num)
{
    Write($"{Math.Pow(i, 2)}, ");
    i++;
}
