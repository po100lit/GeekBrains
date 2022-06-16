using System;
using static System.Console;
Clear();

/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N через метод.
4  -> 24
5  -> 120
*/

Write("Введита число: ");
int A = int.Parse(ReadLine()!);
WriteLine($"Произведение чисел от 1 до {A} = {Prod(A)}");

int Prod(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++) sum *= i;
    return sum;
}