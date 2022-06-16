using static System.Console;
Clear();

/*
Задача 33:**Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да
*/

Write("Введите количество элементов массива: ");
int amount = Convert.ToInt32(ReadLine()!);
var array = new int[amount].Select(x => new Random().Next(-100, 100)).ToArray();

Write(String.Join(", ", array));
WriteLine();

Write("Введите искомое число: ");
int num = Convert.ToInt32(ReadLine()!);
WriteLine(FindNum(array, num) ? $"В массиве есть число {num}" : $"В массиве нет числа {num}");


bool FindNum(int[] array, int num)
{
    foreach (int item in array)
    {
        if (item == num) return true;
    }
    return false;
}
