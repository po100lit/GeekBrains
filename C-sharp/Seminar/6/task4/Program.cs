using static System.Console;
Clear();

/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Write("Сколько чисел Фибоначи напечатать?: ");
double fn = Convert.ToDouble(ReadLine());

double f1 = 0;
double f2 = 1;
Write($"{f1} {f2}");

for (int i = 0; i < fn - 2; i++)
{
    double sum = f1 + f2;
    Write($" {sum}");
    f1 = f2;
    f2 = sum;
}
