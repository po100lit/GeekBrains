using System;
using static System.Console;

Clear();

/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Write("Введите пятизначное число: ");

string var = ReadLine()!;

if (var[0] == var[4] && var[1] == var[3])
{
    WriteLine($"число {var} - палиндром");
}
else
{
    WriteLine($"число {var} - НЕ палиндром");
}
