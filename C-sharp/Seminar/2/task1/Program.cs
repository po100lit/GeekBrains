using System;
using static System.Console;

Console.Clear();

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
int a1 = num / 10; // первая цифра двузначного числа
int a2 = num % 10; // вторая цифра двузначного числа
if (a1 > a2)
{
    WriteLine($"{num} -> {a1}");
}
else
{
    WriteLine($"{num} -> {a2}");
}
