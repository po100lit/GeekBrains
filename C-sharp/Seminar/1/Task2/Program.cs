// int.Parse(ReadLine()) = Convert.ToInt32(ReadLine())

using System;
using static System.Console;


int num1 = int.Parse(ReadLine()!);
int num2 = int.Parse(ReadLine()!);
if (num2 == num1 * num1)
{
    WriteLine("yes");
}
else
{
    WriteLine("no");
}
