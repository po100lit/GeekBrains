using static System.Console;
Clear();

/*
**Задача 35:**Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
*/

var array = new int[123].Select(x => new Random().Next(0, 1000)).ToArray();
var count = 0;

foreach (var item in array)
{
    if (item >= 10 && item <= 99) count++;
}

WriteLine($"В массиве {count} чисел в заданном диапазоне");
// WriteLine(String.Join(" ", array));
