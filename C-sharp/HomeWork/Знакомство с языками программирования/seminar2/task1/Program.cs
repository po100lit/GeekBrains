using System;
using static System.Console;

Clear();

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(ReadLine());
int result = num / 10 % 10;
WriteLine(result);
