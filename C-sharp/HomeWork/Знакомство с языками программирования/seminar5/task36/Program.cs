using static System.Console;
Clear();

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Write("Введите количество элементов массива: ");
var amount = Convert.ToInt32(ReadLine()!);
var array = new int[amount].Select(x => new Random().Next(-100, 100)).ToArray();

var sum = 0;
for (var i = 0; i < amount; i++) if (i % 2 == 0) sum += array[i];

Write(String.Join(", ", array));
WriteLine();
WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
