using static System.Console;
Clear();

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Write("Введите числа через пробел: ");
int[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

var count = 0;
foreach (var item in array) if (item > 0) count++;

WriteLine($"Чисел больше нуля -> {count}");
