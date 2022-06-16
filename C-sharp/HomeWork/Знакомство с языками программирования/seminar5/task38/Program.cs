using static System.Console;
Clear();

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Write("Введите количество элементов массива: ");
var amount = Convert.ToInt32(ReadLine()!);
var array = new int[amount].Select(x => new Random().Next(-1000, 1000)).ToArray();

var min = array[0];
var max = array[0];
int diff;

foreach (var item in array)
{
    if (item < min) min = item;
    if (item > max) max = item;
}

diff = max - min;

Write(String.Join(", ", array));
WriteLine();
WriteLine($"Разница между максимальным {max} и минимальным {min} элементами равна {diff}");
