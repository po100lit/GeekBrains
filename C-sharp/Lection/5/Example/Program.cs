using static System.Console;
Clear();

// лучше явно указывать тип переменных (как в строке 8), если это возможно
// неявная типизация (как в строке 11) не приветствуется
// однако для строки 14 - это допустимо, поскольку неизвестно что будет на выходе

int a = 12;
WriteLine(a.GetType().Name); // Name необязательно

var b = 234;
WriteLine(b.GetType());

var data = new int[] { 1, 2, 3, 4 }.Where(e => e > 0).Select(e => new { q = e, w = e + 1 });
WriteLine(data.GetType());
