using static System.Console;
Clear();

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Write("Введите десятичное число: ");
int decNumber = Convert.ToInt32(ReadLine());
Write("В какую системы счисления перевести: ");
int otherSystem = Convert.ToInt32(ReadLine());

Console.WriteLine(DecToNum(decNumber, otherSystem));

string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}
