using System;
using static System.Console;
Clear();

string caption = "Intensive C# DEMO text";
int screenWidthPosition = (WindowWidth - caption.Length) / 2;
int screenHeightPosition = WindowHeight / 2;
DrawText(caption, screenWidthPosition, screenHeightPosition);

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);

// DrawText("Intensive C# Demo text", 629, 360); // 629 и 360 антипаттерны

void DrawText(string text, int left, int top)
{
    SetCursorPosition(left, top);
    WriteLine(text);
}
