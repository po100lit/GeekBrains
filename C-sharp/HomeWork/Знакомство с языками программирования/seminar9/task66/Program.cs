using static System.Console;
Clear();

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Write("Введите начальнео число: ");
int m = int.Parse(ReadLine()!);
Write("Введите конечное число: ");
int n = int.Parse(ReadLine()!);

WriteLine(SumElement(m, n));

int SumElement(int a, int b)
{
    if (a > b) return 0;
    return a + SumElement(a + 1, b);
}
