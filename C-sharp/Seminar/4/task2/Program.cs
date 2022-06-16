using System;
using static System.Console;
Clear();

/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе, используя метод.
456 -> 3
78 -> 2
89126 -> 5
*/

Write("Введите число: ");
int num = int.Parse(ReadLine()!);

int result = Counter(Math.Abs(num));
WriteLine($"В числе {num} - {result} цифр.");

int Counter(int a)
{
    int count = 1;
    while (a / 10 > 0)
    {
        a /= 10;
        count += 1;
    }
    return count;
}