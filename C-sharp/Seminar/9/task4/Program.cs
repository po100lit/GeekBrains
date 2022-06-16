using static System.Console;
Clear();

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Write("Введите число, возводимое в степень: ");
int a = int.Parse(ReadLine()!);
Write("Введите показатель степени: ");
int b = int.Parse(ReadLine()!);

WriteLine(PowerNumber(a, b));

int PowerNumber(int num, int pow)
{
    while (pow != 0) return num * PowerNumber(num, pow - 1);
    return 1;
}
