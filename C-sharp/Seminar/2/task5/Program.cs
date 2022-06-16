using System;
using static System.Console;

Console.Clear();

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Write("Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine());

string result = (num1*num1 == num2)?$"{num2} - это {num1} в квадрате":(num2*num2 == num1)?$"{num1} - это {num2} в квадрате":$"ниодно из чисел НЕ является квадратом другого";
WriteLine(result);
