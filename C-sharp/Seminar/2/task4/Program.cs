using System;
using static System.Console;

Console.Clear();

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());

string result = (num%7 == 0 && num%23 == 0)?$"{num} кратно 7 и 23":$"{num} не кратно 7 и 23";
WriteLine(result);
