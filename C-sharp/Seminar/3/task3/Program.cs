using System;
using static System.Console;

Clear();

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Write("Введите координату X1: ");
double x1 = Convert.ToDouble(ReadLine());
Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(ReadLine());
Write("Введите координату X2: ");
double x2 = Convert.ToDouble(ReadLine());
Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(ReadLine());

double lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
WriteLine(Math.Round(lenght, 2));
