using static System.Console;
Clear();

/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Write("Введите конечное число: ");
int n = int.Parse(ReadLine()!);

string result = GetNumbers(1, n);
WriteLine(result);

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + GetNumbers(start + 1, end));
}
