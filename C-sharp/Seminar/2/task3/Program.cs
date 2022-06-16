using System;
using static System.Console;

Console.Clear();

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
int max = 0;
int min = 0;

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

if (max % min == 0)
{
    WriteLine($"{max} кратно {min}");
}
else
{
    WriteLine($"{max} некратно {min}, остаток {max % min}");
}