using static System.Console;
Clear();

/*
Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
Write("Сколько чисел вывести: ");
int n = int.Parse(ReadLine()!);

Write($"{num1} {num2} ");
WriteLine(FourierSeries(num1, num2, n - 2));

string FourierSeries(int start, int end, int lenght)
{
    return (lenght == 0) ? "" : (start + end + " " + FourierSeries(end, start + end, lenght - 1));
    //if (lenght == 0) return "";
    //return (start + end + " " + FourierSeries(end, start + end, lenght - 1));
}
