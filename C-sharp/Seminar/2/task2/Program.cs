using System;
using static System.Console;

Console.Clear();

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
WriteLine(num);
int result = num / 100 * 10 + num % 10;
WriteLine(result);
