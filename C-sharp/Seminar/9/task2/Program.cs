using static System.Console;
Clear();

/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

Write("Введите начальное число: ");
int m = int.Parse(ReadLine()!);
Write("Введите конечное число: ");
int n = int.Parse(ReadLine()!);

string result = GetNumbers(m, n);
WriteLine(result);

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + GetNumbers(start + 1, end));
}
