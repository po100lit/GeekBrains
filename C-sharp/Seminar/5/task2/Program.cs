using static System.Console;
Clear();

/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Write("Введите количество элементов массива: ");
int amount = Convert.ToInt32(ReadLine()!);
var array = new int[amount].Select(x => new Random().Next(-100, 100)).ToArray();

Write(String.Join(", ", array));
WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

Write(String.Join(", ", array));