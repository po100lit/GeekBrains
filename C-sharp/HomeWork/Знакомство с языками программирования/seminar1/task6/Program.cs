using System;
using static System.Console;

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
if (num%2 == 0)
{
    WriteLine($"число {num} - чётное");
}
else
{
    WriteLine($"число {num} - нечётное");
}
