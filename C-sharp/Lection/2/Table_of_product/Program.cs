using System;
using static System.Console;

Clear();

for (int m = 2; m <= 10; m++)
{
    for (int n = 2; n <= 10; n++)
    {
        WriteLine($"{m} x {n} = {m * n}");
    }
    WriteLine();
}