using System;
using static System.Console;

Clear();

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(ReadLine());
Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(ReadLine());
Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(ReadLine());

Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(ReadLine());
Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(ReadLine());
Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(ReadLine());

double lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
WriteLine($"расстояние между точками равно {Math.Round(lenght,2)}");
