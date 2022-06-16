using System;
using static System.Console;

Clear();

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Write("Enter number of quater: ");
int num = Convert.ToInt32(ReadLine());

switch (num)
{
    case 1:
        {
            WriteLine("x>0, y>0");
            break;
        }
    case 2:
        {
            WriteLine("x<0, y>0");
            break;
        }
    case 3:
        {
            WriteLine("x<0, y<0");
            break;
        }
    case 4:
        {
            WriteLine("x>0, y<0");
            break;
        }
    default:
        {
            WriteLine("quater must be 1 to 4");
            break;
        }
}