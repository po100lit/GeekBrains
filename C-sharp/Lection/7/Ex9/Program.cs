using static System.Console;
Clear();

/*
числа фибоначи с выводом времени выполнения и количества итераций
*/

decimal fRec = 0;
decimal fIte = 0;

ReadLine();
DateTime dt = DateTime.Now;
for (int n = 1; n < 40; n++)
{
    WriteLine($"FibIte({n}) = {FibIte(n)} итераций = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
}
WriteLine($"Время выполнения скрипта: {(DateTime.Now - dt).TotalMilliseconds} милисекунд");
WriteLine();
ReadLine();
dt = DateTime.Now;
for (int n = 1; n < 40; n++)
{
    WriteLine($"FibRec({n}) = {FibRec(n)} итераций = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
WriteLine($"Время выполнения скрипта: {(DateTime.Now - dt).TotalMilliseconds} милисекунд");

decimal FibRec(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibRec(n - 1) + FibRec(n - 2);
}

decimal FibIte(int n)
{
    fIte++;
    decimal res = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        res = f0 + f1;
        f0 = f1;
        f1 = res;
        fIte++;
    }
    return res;
}
