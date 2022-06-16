using static System.Console;
Clear();

/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int len = 10;
int[] ar = new int[len].Select(x => x = new Random().Next(0, 10)).ToArray();
WriteLine(String.Join(" ", ar));

for (int i = 0; i < len / 2; i++)
{
    int k = ar[i];
    ar[i] = ar[len - i - 1];
    ar[len - i - 1] = k;
}

WriteLine(String.Join(" ", ar));
