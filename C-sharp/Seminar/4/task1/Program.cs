using System;
using static System.Console;
Clear();

/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Write("Введита число: ");
int A = int.Parse(ReadLine()!);
WriteLine($"Сумма чисел от 1 до {A} = {Summ(A)}");

int Summ(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++) sum += i;
    return sum;
}