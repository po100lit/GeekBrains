using System;
using static System.Console;

Clear();

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Write("Ввведите число от 1 до 7: ");
int num = Convert.ToInt32(ReadLine());
string result = (num == 6 | num == 7)?$"выходной день":$"будний день";
WriteLine(result);
