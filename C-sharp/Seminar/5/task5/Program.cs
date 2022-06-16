using static System.Console;
Clear();

/*
**Задача 37:**Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21
*/

Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(ReadLine()!);
var array = new int[N].Select(x => new Random().Next(20)).ToArray();

WriteLine($"Исходный массив: {String.Join(", ", array)}");
WriteLine();

ProductPairs(array);

void ProductPairs(int[] arr)
{
    int product = 1;
    int[] newArray = (N % 2 == 0) ? new int[N / 2] : new int[N / 2 + 1];
    for (int i = 0; i < N / 2; i++)
    {
        product = arr[i] * arr[N - 1 - i];
        newArray[i] = product;
    }

    if (N % 2 == 1) newArray[N / 2] = arr[N / 2];
    Write($"Массив попарных произведений: {String.Join(", ", newArray)}");
}
