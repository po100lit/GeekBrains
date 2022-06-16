using static System.Console;
Clear();

/*
Задача 72: Заданы 2 массива: info и data.
В массиве data хранятся двоичные представления нескольких чисел (без разделителя).
В массиве info хранится информация о количестве бит, которые занимают числа из массива data.
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

if (data.Length != info.Sum())
{
    WriteLine("Ошибка данных.");
    return;
}

WriteLine(String.Join(", ", BinToDecimal(data, info)));

/*
// Используя строки
int[] BinToDecimal(int[] dataArr, int[] infoArr)
{
    int[] res = new int[infoArr.Length];
    string datastr = String.Join("", dataArr);
    for (int i = 0; i < res.Length; i++)
    {
        string subData = datastr.Substring(0, infoArr[i]);
        res[i] = Convert.ToInt32(subData, 2);
        datastr = datastr.Remove(0, infoArr[i]);
    }
    return res;
}
*/

// используя математику
int[] BinToDecimal(int[] data, int[] info)
{
    int[] res = new int[info.Length];
    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        string summ = String.Empty;
        for (int j = 0; j < info[i]; j++)
        {
            summ += data[count + j];
        }
        count += info[i];
        res[i] = Convert.ToInt32(summ, 2);
    }
    return res;
}
