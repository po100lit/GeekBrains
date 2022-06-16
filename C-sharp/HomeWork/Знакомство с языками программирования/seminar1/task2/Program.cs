using System;
using static System.Console;

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
if (num1 > num2)
{
    WriteLine($"первое число {num1} больше {num2}");
}
else
{
    WriteLine($"второе число {num2} больше {num1}");
}
