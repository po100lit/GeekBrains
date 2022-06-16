using System;
using static System.Console;

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Write("Введите число: ");
int num = int.Parse(ReadLine()!);

int startNum = 2;

while (startNum <= num)
{
    Write($"{startNum}, ");
    startNum += 2;
}
