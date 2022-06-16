using System;
using static System.Console;
Clear();

Random r = new Random();

CursorVisible = false;
while (true)
{
    SetCursorPosition(
        left: r.Next(WindowWidth),
        top: r.Next(WindowHeight)
    );
    ForegroundColor = ConsoleColor.Green; // цвет текста в консоли
    Write(r.Next(10));
    Thread.Sleep(10);
    ResetColor();
}

/*
Black       0   Черный цвет.
Blue        9   Синий цвет.
Cyan       11   Голубой цвет (сине-зеленый).
DarkBlue    1   Темно - синий цвет.
DarkCyan    3   Темно - голубой цвет(темный сине - зеленый).
DarkGray    8   Темно - серый цвет.
DarkGreen   2   Темно - зеленый цвет.
DarkMagenta 5   Темно - пурпурный цвет(темный фиолетово - красный).
DarkRed     4   Темно - красный цвет.
DarkYellow  6   Темно - желтый цвет(коричнево - желтый).
Gray        7   Серый цвет.
Green      10   Зеленый цвет.
Magenta    13   Пурпурный цвет (фиолетово-красный).
Red        12   Красный цвет.
White      15   Белый цвет.
Yellow     14   Желтый цвет.
*/