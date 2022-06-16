using System;
using static System.Console;
Clear();

/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = new Random().Next(10000);
string numbers = Convert.ToString(number);

WriteLine($"Сумма цифр числа {number} = {sumOfDigits(number)}");

int sumOfDigits(int number)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
