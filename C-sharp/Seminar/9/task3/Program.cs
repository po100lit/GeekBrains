using static System.Console;
Clear();

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/

Write("Введите число: ");
int m = int.Parse(ReadLine()!);

WriteLine(SummNumber(m));

int SummNumber(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SummNumber(num /= 10);
}
