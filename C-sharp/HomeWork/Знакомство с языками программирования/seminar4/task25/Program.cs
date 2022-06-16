using System;
using static System.Console;
Clear();

/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
*/

Write("Введите число, возводимое в степень: ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите показатель степени: ");
int num2 = Convert.ToInt32(ReadLine());

WriteLine($"{num1}^{num2} = {forAPowerB(num1, num2)}");
WriteLine($"{num1}^{num2} = {whileAPowerB(num1, num2)}");

int forAPowerB(int a, int b) // используя цикл "for"
{
    int power = 1;
    for (int i = 0; i < b; i++) power *= a;
    return power;
}

int whileAPowerB(int a, int b) // используя цикл "while"
{
    int power = 1;
    int count = 0;
    while (count < b)
    {
        power *= a;
        count++;
    }
    return power;
}
