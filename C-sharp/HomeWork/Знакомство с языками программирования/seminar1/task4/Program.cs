using System;
using static System.Console;

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
Write("Введите третье число: ");
int num3 = int.Parse(ReadLine()!);

if (num1 > num2 & num1 > num3)
{
    WriteLine($"первое число {num1} - максимальное из введённых");
}
else if (num2 > num1 & num2 > num3)
{
    WriteLine($"второе число {num2} - максимальное из введённых");
}
else
{
    WriteLine($"третье число {num3} - максимальное из введённых");
}
