using static System.Console;
Clear();

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

ForegroundColor = ConsoleColor.Red;
WriteLine("ВНИМАНИЕ!!! Функция растёт очень быстро\nВо избежание ошибки 'Stack overflow',\nне вводите большие числа!!!");
ResetColor();
Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"A({m},{n}) = {Ackermann(m, n)}");

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Ackermann(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Ackermann(m - 1, Ackermann(m, n - 1));
    else return n + 1;
}
