using static System.Console;
Clear();

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Write("Введите количество элементов массива: ");
var amount = Convert.ToInt32(ReadLine()!);
var array = new int[amount].Select(x => new Random().Next(100, 1000)).ToArray();

var count = 0;

foreach (var item in array) if (item % 2 == 0) count++;

Write(String.Join(", ", array));
WriteLine();
Write($"Четных чисел в массиве {count}");
