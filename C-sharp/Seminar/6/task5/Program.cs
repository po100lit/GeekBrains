using static System.Console;
Clear();

/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Write("Введите длину массива: ");
int size = Convert.ToInt32(ReadLine());
int[] array = new int[size].Select(x => x = new Random().Next(100)).ToArray();

WriteLine($"Исходный массив: {String.Join(" ", array)}");

int[] newArray = new int[size];
for (int i = 0; i < array.Length; i++) newArray[i] = array[i];

WriteLine($"Конечный массив: {String.Join(" ", newArray)}");
