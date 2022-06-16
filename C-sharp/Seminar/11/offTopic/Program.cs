using System;
using static System.Console;
Clear();

/*
Вывести все простые числа от 2 до N, используя рекурсию.
*/

Write("Введите число: ");
int n = int.Parse(ReadLine()!);

for (int i = 2; i <= n; i++)
{
    if (PrimeNumber(i)) WriteLine($"Число {i} простое");
    else continue;
}

bool PrimeNumber(int num, int i = 2)
{
    if (num == 2) return true;
    else if (num % i == 0) return false;
    else if (i < num / 2) return PrimeNumber(num, i + 1);
    else return true;
}
