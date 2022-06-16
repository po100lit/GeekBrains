using System;
using System.Linq;
using static System.Console;
Clear();

string text = "(2,3) (5,7) (9,4) (8,6)"
            .Replace("(", "")
            .Replace(")", "");
WriteLine(text);

var data = text.Split(" ")
            .Select(item => item.Split(',')) // на выходе массив
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // на выоде кортеж чисел
            .Where(e => e.x % 2 == 1) // фильтр координата Х - нечётная
            .Select(point => (point.x * 10, point.y * 3)) // изменяем исходные значения
            .ToArray(); // на выходе массив массивов

for (int i = 0; i < data.Length; i++)
{
    WriteLine(data[i]);
    /*
    // если нет 13 строки
    for (int j = 0; j < data[i].Length; j++)
    {
        WriteLine(data[i][j]);
    }
    WriteLine();*/

}
