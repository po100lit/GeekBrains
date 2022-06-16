using static System.Console;
Clear();

/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.

M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/

Write("Введите начальнео число: ");
int m = int.Parse(ReadLine()!);
Write("Введите конечное число: ");
int n = int.Parse(ReadLine()!);

string result = DescendingNumbers(m, n);
WriteLine(result);

string DescendingNumbers(int a, int b)
{
    if (a >= b) return a.ToString();
    return (b + " " + DescendingNumbers(a, b - 1));
}
