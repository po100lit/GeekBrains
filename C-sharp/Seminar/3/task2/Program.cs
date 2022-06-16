using System;
using static System.Console;

Clear();

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Write("Введите X: ");
int x = Convert.ToInt32(ReadLine());
Write("Введите Y: ");
int y = Convert.ToInt32(ReadLine());

if (x > 0 & y > 0)
{
    WriteLine("1 четверть");
}
else if (x < 0 & y > 0)
{
    WriteLine("2 четверть");
}
else if (x < 0 & y < 0)
{
    WriteLine("3 четверть");
}
else
{
    WriteLine("4 четверть");
}
