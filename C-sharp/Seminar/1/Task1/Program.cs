// int.Parse(ReadLine()) = Convert.ToInt32(ReadLine())

using System;
using static System.Console;

// Task1

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
WriteLine($"Квадрат введенного числа равен {num*num}");
