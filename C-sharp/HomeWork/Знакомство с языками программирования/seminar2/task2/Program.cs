using System;
using static System.Console;

Clear();

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num2 = num % 10;
WriteLine($"{num} -> {num1}{num2}");
