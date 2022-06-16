// int.Parse(ReadLine()) = Convert.ToInt32(ReadLine())

using System;
using static System.Console;


int num = int.Parse(ReadLine()!);

if (num == 1)
{
    WriteLine("Понедельник");
}
else if (num == 2)
{
    WriteLine("Вторник");
}
else if (num == 3)
{
    WriteLine("Среда");
}
else if (num == 4)
{
    WriteLine("Четверг");
}
else if (num == 5)
{
    WriteLine("Пятница");
}
else if (num == 6)
{
    WriteLine("Суббота");
}
else if (num == 7)
{
    WriteLine("Воскресенье");
}
